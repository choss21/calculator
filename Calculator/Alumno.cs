using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Alumno
    {
        public int? AlumnoId { get; set; }
        public string NombreCompleto
        {
            get
            {
                return Nombres + " " + ApellidoPaterno + " " + ApellidoMaterno;
            }
        }
        public string Nombres { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int Edad
        {
            get
            {
                int year = DateTime.Now.Year - FechaNacimiento.Year;
                int month = DateTime.Now.Month - FechaNacimiento.Month;
                int day = DateTime.Now.Day - FechaNacimiento.Day;
                if (month < 0)
                {
                    return year - 1;
                }
                else if (month == 0)
                {
                    return day <= 0 ? year : year - 1;
                }
                else
                {
                    return year;
                }
            }
        }

    }
}
