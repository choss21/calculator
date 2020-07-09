using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLib
{
    public abstract class OperacionAritmetica
    {
        //es una clase que no se pueded instanciar, es donde podemos definir metodos completos.
        //la clase abstracta te pertmite hacer un metodo abstracto

        public double Numero1{ get; set;}
        public double Numero2{ get; set; }

        public abstract void RealizarOperacion();
            //no sabe que va hacer
        
    }
}
