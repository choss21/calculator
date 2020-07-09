using MathLib;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                var numero1 = Convert.ToDouble(txtNumero1.Text);
                var numero2 = Convert.ToDouble(txtNumero2.Text);
                //var obj = new Operaciones();
                //var resultado = obj.Suma(numero1, numero2);
                var resultado = OperacionesHelper.Suma(numero1, numero2);

                MessageBox.Show("El resultado es " + resultado);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error " + ex.Message);
            }


            //int variable1 = 10;
            //string variable2 = "10";
            //float variable3 = (float)20.45;
            //double variable4 = (double)20.45;
            //decimal variable5 = (decimal)20.45;
            //char variable6 = 'a';
            //var obj = new Operaciones();
            //var resultado = obj.Suma(10, 10);
            //MessageBox.Show("El resultado es " + resultado);
        }

        private void txtNumero1_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarsoloNumeros(sender, e);
        }
        private void txtNumero2_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarsoloNumeros(sender, e);
        }
        private void ValidarsoloNumeros(object sender, KeyPressEventArgs e)
        {
            //lblEstatus.Text = "Tecla precionada " + e.KeyChar;

            if (char.IsDigit(e.KeyChar) || e.KeyChar == '.' || (int)e.KeyChar == 8)
            {
                var textboxPrecionado = sender as TextBox;
                if (textboxPrecionado.Text.Contains(".") && e.KeyChar == '.')
                {
                    e.Handled = true;
                }
                else
                {
                    lblEstatus.Text = "";
                    e.Handled = false;
                }
            }
            else
            {
                lblEstatus.Text = "Solo se aceptan numeros y usted preciono " + e.KeyChar;
                e.Handled = true;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            lblEstatus.Text = "";
        }

        private void txtNumero1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNumero1.Text)) return;
            try
            {
                lblNumeroLetras.Text = OperacionesHelper.HumanizerNumero(Convert.ToInt32(txtNumero1.Text));
                //lblNumeroLetras.Text = Operaciones.NumeroALetras(Convert.ToInt32(txtNumero1.Text));
            }
            catch (Exception)
            {
            }
        }
        private void btnPruebaPolimorfismo_Click(object sender, EventArgs e)
        {
            //var figurasGeometricas = new FiguraGeometrica[5];
            //figurasGeometricas[0] = new Rectangulo(2,2);
            //figurasGeometricas[1] = new Triangulo(5,5);
            //figurasGeometricas[2] = new Rectangulo(6,6);
            //figurasGeometricas[3] = new Cuadrado(8);
            //figurasGeometricas[4] = new Triangulo(9,9);
            var figurasGeometricas = new List<FiguraGeometrica>();
            figurasGeometricas.Add(new Rectangulo(2, 2));
            figurasGeometricas.Add(new Triangulo(5, 5));
            figurasGeometricas.Add(new Rectangulo(6, 6));
            figurasGeometricas.Add(new Cuadrado(8));
            figurasGeometricas.Add(new Triangulo(9, 9));


            for (int i = 0; i < figurasGeometricas.Count(); i++)
            {
                MessageBox.Show($"El area del {figurasGeometricas[i].TipoFigura} {i + 1} es: {figurasGeometricas[i].CalcularArea()} ");
            }

            //var objCuadrado = new Cuadrado(5);
            //var areaCuadrado = objCuadrado.CalcularArea();
            //MessageBox.Show("El area del cuadrado de lado " + objCuadrado.TamanioLado + " es: " + areaCuadrado);

            //var objRectangulo = new Rectangulo(10, 5, "Verde");
            //var areaRectangulo = objRectangulo.CalcularArea();
            //MessageBox.Show(string.Format("El area del rectangulo de base {0} y altura {1} es {2}", objRectangulo.Base, objRectangulo.Altura, areaRectangulo));

            //var objTriangulo = new Triangulo(20, 30);
            //var areaTriangulo = objTriangulo.CalcularArea();
            //MessageBox.Show($"El area del triangulo de base {objTriangulo.Base} y altura {objTriangulo.Altura} es {areaTriangulo}");



        }
    }

}

