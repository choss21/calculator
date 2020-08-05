using Calculator.BO;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Calculator.Model.Mapping
{
    public class CarreraMapping : EntityTypeConfiguration<Carrera>
    {
        public CarreraMapping()
        {
            ToTable("Carreras");
            HasKey(x => x.CarreraId);
            Property(x => x.CarreraId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);//Es autonumerico

            Property(x => x.Nombre)
                .IsRequired()
                .HasMaxLength(150);
            Property(x => x.Clave)
                .IsOptional()
                .HasMaxLength(20);
        }
    }
}
