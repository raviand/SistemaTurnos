using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiTurnos.Models
{
    public class Atencion
    {
        public int AtencionId { get; set; }
        public DateTime FechaAtencion { get; set; }
        public int ProfesionalId { get; set; }
        public string DetalleAtencion { get; set; }
    }
}