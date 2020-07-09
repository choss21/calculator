using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLib
{
    public abstract class FiguraGeometrica
    {
        public string Color { get; set; }
        public abstract string TipoFigura { get; }
        public abstract int NumeroLados { get; }
        public abstract double CalcularArea();
    }
}
