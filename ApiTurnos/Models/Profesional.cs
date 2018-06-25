using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiTurnos.Models
{
    public class Profesional
    {
        public int ProfesionalId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Mail { get; set; }

        public virtual ICollection<DiaHabilitado> DiasHabilitados { get; set; }
        public virtual ICollection<ServicioMedico> ServiciosMedicos { get; set; }
        public virtual ICollection<Telefono> Telefonos { get; set; }
        public virtual ICollection<Especialidad> Especialidades { get; set; }
    }
}