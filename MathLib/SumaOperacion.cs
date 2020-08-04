using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLib
{
    public class SumaOperacion : OperacionAritmetica
    {
        public override void RealizarOperacion()
        {
            Resultado = Numero1 + Numero2;
        }
    }
}
