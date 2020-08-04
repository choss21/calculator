using Calculator.BO;
using Calculator.Model.Context.Mapping;
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
        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<Carrera> Carreras { get; set; }
        public ModelContext():base("CalculatorBD")
        {
            Configuration.LazyLoadingEnabled = true;
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //aqui es donde voy a configurar mis mappings
            modelBuilder.Configurations.Add(new AlumnoMapping());
            modelBuilder.Configurations.Add(new CarreraMapping());
        }

    }
}
