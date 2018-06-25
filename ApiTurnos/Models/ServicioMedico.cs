using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiTurnos.Models
{
    public class ServicioMedico
    {
        public int ServicioMedicoId { get; set; }
        public string NompreServicio { get; set; }
        public string NumeroCredencial { get; set; }

        public virtual ICollection<Plan> Planes { get; set; }
    }
}