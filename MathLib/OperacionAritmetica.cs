using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLib
{
    public abstract class OperacionAritmetica
    {
        public double Numero1 { get; set; }
        public double Numero2 { get; set; }
        public double Resultado { get; set; }
        public abstract void RealizarOperacion();
    }
}
