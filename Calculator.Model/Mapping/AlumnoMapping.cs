using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Model.Mapping
{
    class AlumnoMapping:EntityTypeConfiguration<Alumno>
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
                .IsOptional();
        }
    }
}
