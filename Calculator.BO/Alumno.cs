using System;

namespace Calculator.BO
{
    public class Alumno
    {
        public string Matricula { get; set; }
        public string Nombres { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public string Correo { get; set; }
        public int? CarreraId { get; set; }
        //el virtual es para que LazyLoading Funcione
        public virtual Carrera Carrera { get; set; }
    }
}
