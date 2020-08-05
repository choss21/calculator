using Calculator.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Model.Context.Mapping
{
    public class CarreraMapping:EntityTypeConfiguration<Carrera>
    {
        public CarreraMapping()
        {
            ToTable("Carreras");
            Has
        }
    }
}
