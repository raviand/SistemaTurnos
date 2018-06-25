using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
namespace ApiTurnos.Models
{
    public class Paciente
    {
        public int PacienteId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Dni { get; set; }
        //public string Telefono { get; set; }
        public int DireccionId { get; set; }
        public string mail { get; set; }
        public DateTime FechaIngreso { get; set; }

        public virtual ICollection<Atencion> Atenciones { get; set; }
        public virtual ICollection<Telefono> Telefonos { get; set; }
    }
}