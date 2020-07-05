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
                var resultado = Operaciones.Suma(numero1, numero2);

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

        }


    }

}

