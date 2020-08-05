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
        }
    }
}
