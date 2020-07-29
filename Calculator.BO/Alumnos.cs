using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.BO
{
    public class Alumnos
    {
        public string Matricula { get; set; }
        public string Nombre { get; set; }
        public string  ApellidoPaterno { get; set; }
        public string  ApellidoMaterno { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public string Correo { get; set; }
        public int? CarreraId { get; set; }
        public Carrera Carrera { get; set; }

    }
}
