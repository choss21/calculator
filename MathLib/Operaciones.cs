﻿using System;
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

        public static bool EsPar(int Num)
        {
            if(Convert.ToBoolean(Num % 2 == 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
    }
}
