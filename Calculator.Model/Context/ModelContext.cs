using Calculator.BO;
using Calculator.Model.Mapping;
using System.Data.Entity;

namespace Calculator.Model.Context
{
    public class ModelContext : DbContext
    {
        #region DbSets
        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<Carrera> Carreras { get; set; }
        #endregion
        public ModelContext() : base("CalculatorBD")
        {
            //Primera forma
            Database.SetInitializer<ModelContext>(new CreateDatabaseIfNotExists<ModelContext>());
            //Database.SetInitializer<ModelContext>(new DropCreateDatabaseIfModelChanges<ModelContext>());
            //Database.SetInitializer<ModelContext>(new DropCreateDatabaseAlways<ModelContext>());
            //Database.SetInitializer<ModelContext>(new SchoolDBInitializer());
            //Database.SetInitializer<ModelContext>(new MigrateDatabaseToLatestVersion<ModelContext, Configuration>());
            //Database.SetInitializer<ModelContext>(new MigrateDatabaseToLatestVersion<ModelContext, Configuration>());
            //Esto hay que removerlo dependiendo Como deseen trabajar el Modelo
            //Database.SetInitializer<ModelContext>(new DatabaseInitializer());
            Configuration.LazyLoadingEnabled = true;
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Aqui es donde voy a configurar mis Mappings
            modelBuilder.Configurations.Add(new AlumnoMapping());
            modelBuilder.Configurations.Add(new CarreraMapping());
        }
    }
}
