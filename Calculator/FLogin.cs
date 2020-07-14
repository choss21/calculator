using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class FLogin : Form
    {
        public FLogin()
        {
            InitializeComponent();
        }

        private void btnVerContraseña_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;

            //if (txtPassword.UseSystemPasswordChar == true)
            //{
            //    txtPassword.UseSystemPasswordChar = false;
            //}
            //else
            //{
            //    txtPassword.UseSystemPasswordChar = true;
            //}

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Ejemplo de conexion a base de datos
            var cadenaDeConexion = "server=(local); database=Alumnos ; integrated security=true";
            var conexion = new SqlConnection(cadenaDeConexion);

            SqlCommand command = new SqlCommand("SELECT * FROM Alumnos;", conexion);
            conexion.Open();

            SqlDataReader reader = command.ExecuteReader();
            var alumnos = new List<Alumno>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", reader.GetInt32(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3),
                        reader.GetDateTime(4));
                    alumnos.Add(new Alumno()
                    {
                        AlumnoId = reader.GetInt32(0),
                        Nombres = reader.GetString(1),
                        ApellidoMaterno = reader.GetString(2),
                        ApellidoPaterno = reader.GetString(3),
                        FechaNacimiento = reader.GetDateTime(4)
                    });
                }
            }
            else
            {
                Console.WriteLine("No rows found.");
            }
            reader.Close();



            conexion.Close();
            gridAlumnos.DataSource = alumnos;

        }
    }
}
