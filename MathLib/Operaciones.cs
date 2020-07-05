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
        public static bool esPrimo(int numero)
        {
            int divisor = 2;
            int resto = 0;
            while (divisor < numero)
            {
                resto = numero % divisor;
                if (resto == 0)
                {
                    return false;
                }
                divisor = divisor + 1;
            }
            return true;
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
