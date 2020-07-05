using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace MathLib
{
    //instancia es hacer esto var variable = new NombreClase();   . . . . . . . l. .
    public static class Operaciones
    {
        public static int Suma(int num1, int num2)
        {
            return num1 + num2;
        }
        public static double Suma(double num1, double num2)
        {
            return num1 + num2;
        }

        public static double factorial(double Numero) {

            if (Numero == 0) {
                return 1;
            }
            else {
                return Numero * factorial(Numero - 1);
            }
            
        }
    }
}
