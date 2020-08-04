using Calculator.BO;
using Calculator.Model.Mapping;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Model.Context
{
    public class ModelContext :DbContext
    {
        public is DbSet<Alumno> Alumnos { get; set; }
        public is DbSet<Carrera> Carreras { get; set; }

        public ModelContext():base("CalculatorBD")
        {
            Database.SetInitializer<ModelContext>(new CreateDatabaseIfNotExists<ModelContext>());

            Configuration.LazyLoadingEnabled = true;
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AlumnoMapping());
            modelBuilder.Configurations.Add(new CarreraMapping());

        }

    }
}
