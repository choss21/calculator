using Calculator.BO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Model.Mapping
{
    public class AlumnoMapping : EntityTypeConfiguration<Alumno>
    {
        public AlumnoMapping()
        {
            ToTable("Alumnos");
            HasKey(x => x.Matricula);
            Property(x => x.Matricula)
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(x => x.Nombres)
                .IsRequired()
                .HasMaxLength(100);
            Property(x => x.ApellidoPaterno)
                .IsRequired()
                .HasMaxLength(50);
            Property(x => x.ApellidoMaterno)
                .IsOptional()
                .HasMaxLength(50);
            Property(x => x.FechaNacimiento)
                .IsRequired();
            Property(x => x.Correo)
                .IsOptional()
                .HasMaxLength(50);

            HasRequired(x => x.Carrera)
                .WithMany()
                .HasForeignKey(x => x.CarreraId);



        }
    }
}
