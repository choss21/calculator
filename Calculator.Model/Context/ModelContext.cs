using Calculator.Model.Mapping;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Model.Context
{
    public class ModelContext : DbContext
    {
        public ModelContext() : base("CalculatorBD")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new AlumnoMapping();
            modelBuilder.Configurations.Add(new CarreraMapping());
        }
        
    }
}
