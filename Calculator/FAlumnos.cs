using Calculator.BO;
using Calculator.Model.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class FAlumnos : Form
    {
        public FAlumnos()
        {
            InitializeComponent();
        }

        private void btnGuardarCarrera_Click(object sender, EventArgs e)
        {
            var carreraNueva = new Carrera()
            {
                Nombre = txtCarrera.Text,
                Clave = txtClaveCarrera.Text
            };
            var context = new ModelContext();
            context.Carreras.Add(carreraNueva);
            context.SaveChanges();


            gridCarreras.DataSource = context.Carreras.ToList();
            cargarComboBoxCarreras();
        }

        private void FAlumnos_Load(object sender, EventArgs e)
        {
            cargarListadoAlumnos();
            cargarComboBoxCarreras();
        }
        private void cargarComboBoxCarreras()
        {
            var context = new ModelContext();
            List<Carrera> listadoCarreras = context.Carreras.ToList();//SELECT * FROM Carreras;
            cmbCarrera.DisplayMember = "Nombre";
            cmbCarrera.ValueMember = "CarreraId";
            cmbCarrera.DataSource = listadoCarreras;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty((string)txtMatricula.Tag))
            {
                var context = new ModelContext();
                var nuevoAlumnos = ObtenerAlumnoDeInterfaz();
                context.Alumnos.Add(nuevoAlumnos);//INSERT INTO Alumnos() VALUE() .. . . . .
                context.SaveChanges();
            }
            else
            {
                var sMatriculaEditar = txtMatricula.Tag.ToString();
                var context = new ModelContext();
                var alumnoEditar = context.Alumnos
                                    .Where(x => x.Matricula == sMatriculaEditar)
                                    .FirstOrDefault();
                if (alumnoEditar == null) return;
                //alumnoEditar.Matricula = txtMatricula.Text;
                alumnoEditar = ObtenerAlumnoDeInterfaz(alumnoEditar);
                context.SaveChanges();
            }



            //Cargo en mi GRid la informacion del Alumno
            cargarListadoAlumnos();

        }
        private Alumno ObtenerAlumnoDeInterfaz(Alumno objAlumno = null)
        {
            if (objAlumno == null)
                objAlumno = new Alumno();
            objAlumno.Matricula = txtMatricula.Text;
            objAlumno.Nombres = txtNombres.Text;
            objAlumno.ApellidoMaterno = txtApellidoMaterno.Text;
            objAlumno.ApellidoPaterno = txtApellidoPaterno.Text;
            objAlumno.Correo = txtCorreo.Text;
            objAlumno.FechaNacimiento = dtpFechaNacimiento.Value;
            objAlumno.CarreraId = Convert.ToInt32(cmbCarrera.SelectedValue);

            return objAlumno;
        }
        private void cargarListadoAlumnos()
        {
            var context = new ModelContext();
            List<Alumno> listadoAlumnos = context.Alumnos
                                //.Include("Carrera")
                                .ToList();//SELECT * FROM Alumnos;
            gridAlumnos.DataSource = listadoAlumnos;
        }

        private void gridAlumnos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridAlumnos.SelectedRows.Count <= 0) return;

            string matriculaSeleccionada = gridAlumnos.Rows[e.RowIndex].Cells["Matricula"].Value.ToString();
            var context = new ModelContext();
            //SELECT * FROM ALUMNOS
            var alumnoSeleccionado = context.Alumnos
                                        .Where(x => x.Matricula == matriculaSeleccionada)
                                        .FirstOrDefault();//WHERE MAtricula = 'matriculaSeleccionada'
            //Llenar la interfaz con esta informacion. . . .
            txtMatricula.ReadOnly = true;
            txtMatricula.Tag = alumnoSeleccionado.Matricula;
            txtMatricula.Text = alumnoSeleccionado.Matricula;
            txtNombres.Text = alumnoSeleccionado.Nombres;
            txtApellidoPaterno.Text = alumnoSeleccionado.ApellidoPaterno;
            txtApellidoMaterno.Text = alumnoSeleccionado.ApellidoMaterno;
            cmbCarrera.SelectedValue = alumnoSeleccionado.CarreraId;
            dtpFechaNacimiento.Value = alumnoSeleccionado.FechaNacimiento.Value;
            txtCorreo.Text = alumnoSeleccionado.Correo;
        }

        private void btnPrepararNuevo_Click(object sender, EventArgs e)
        {
            txtMatricula.ReadOnly = false;
            txtMatricula.Tag = "";
            txtMatricula.Clear();
            txtNombres.Clear();
            txtApellidoMaterno.Clear();
            txtApellidoPaterno.Clear();
            txtCorreo.Clear();
            dtpFechaNacimiento.Value = DateTime.Now;
            cmbCarrera.SelectedValue = -1;
        }

        private void btnEliminarAlumno_Click(object sender, EventArgs e)
        {
            if (gridAlumnos.SelectedRows.Count <= 0) return;





            string matriculaSeleccionada = gridAlumnos.Rows[gridAlumnos.SelectedRows[0].Index].Cells["Matricula"].Value.ToString();
            var respuestaUsuario = MessageBox.Show($"¿Esta completamente seguro que desea eliminar el alumno con matricula {matriculaSeleccionada}?",
                 "Confirma que desea eliminar al Alumno", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            //if (respuestaUsuario == DialogResult.Yes)
            //{
            //    MessageBox.Show("El usuario dijo que si");
            //}
            if (respuestaUsuario == DialogResult.No)
            {
                return;//Hace que nos salgamos del metodo
            }
            var context = new ModelContext();
            var alumnoEliminar = context.Alumnos
                                    .Where(x => x.Matricula == matriculaSeleccionada)
                                    .FirstOrDefault();
            if (alumnoEliminar == null) return;
            context.Alumnos.Remove(alumnoEliminar);//DELETE FROM Alumnos WHERE Matricula = 'MatriculaSeleccionada';
            context.SaveChanges();
            MessageBox.Show($"El alumno con matricula {matriculaSeleccionada} ha sido eliminado", "Se ha eliminado un alumno",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            cargarListadoAlumnos();
        }
    }
}
