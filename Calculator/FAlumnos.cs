using Calculator.BO;
using Calculator.Model.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
        }
        private void cargarComboBoxCarreras()
        {
            var context = new ModelContext();
            var listadoCarreras = context.Carreras.ToList();
            cmbCarrera.DisplayMember = "Nombre";
            cmbCarrera.ValueMember = "CarreraId";
            cmbCarrera.DataSource = listadoCarreras;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var nuevoAlumnos = new Alumno()
            {
                Matricula = txtMatricula.Text,
                Nombres = txtNombres.Text,
                ApellidoMaterno = txtApellidoMaterno.Text,
                ApellidoPaterno = txtApellidoPaterno.Text,
                Correo = txtCorreo.Text,
                FechaNacimiento = dtpFechaNacimiento.Value,
                CarreraId = Convert.ToInt32(cmbCarrera.SelectedValue)
            };
            var context = new ModelContext();
            context.Alumnos.Add(nuevoAlumnos);
            context.SaveChanges();
            cargarListadoAlumnos();
            
        }
        private void cargarListadoAlumnos()
        {
            var context = new ModelContext(); 
            List<Alumno> listadoAlumnos = context.Alumnos
                            .ToList();
            gridAlumnos.DataSource = listadoAlumnos;
        }    
    }
}
