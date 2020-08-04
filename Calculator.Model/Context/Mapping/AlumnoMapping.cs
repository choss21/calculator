using Calculator.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Model.Context.Mapping
{
    public class AlumnoMapping : EntityTypeConfiguration<Alumno>
    {
        public AlumnoMapping()
        {
            ToTable("Alumnos");
            HasKey(x => x.Matricula);
            Property(x => x.Matricula)
                .IsRequired()
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);

            Property(x => x.Nombres)
                .IsRequired()
                .HasMaxLength(100);
            Property(x => x.ApellidoPaterno)
               .IsRequired()
               .HasMaxLength(50);
            Property(x => x.ApellidoMaterno)
               .IsRequired()
               .HasMaxLength(50);


        }
    }
}
