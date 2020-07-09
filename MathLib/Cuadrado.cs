using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLib
{
    public class Cuadrado : FiguraGeometrica
    {


        public override string TipoFigura => "Cuadrado";

        public override int NumeroLados => 4;
        public double TamanioLado { get;  }

        public Cuadrado(double tamanioLado, string color = "Blanco")
        {
            this.TamanioLado = tamanioLado;
            this.Color = color;
        }
        public override double CalcularArea()
        {
            return TamanioLado * TamanioLado;
        }
    }
}
