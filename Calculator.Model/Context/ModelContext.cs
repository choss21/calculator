using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Model.Context
{
    public class ModelContext:DbContext
    {
        public ModelContext():base("CalculatorBD")
        {

        }
        
    }
}
