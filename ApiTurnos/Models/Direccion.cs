using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiTurnos.Models
{
    public class Direccion
    {
        public int DireccionId { get; set; }
        public string Calle { get; set; }
        public int NroPuerta { get; set; }
        public int Piso { get; set; }
        public string Departamento { get; set; }
        public int CodigoPostal { get; set; }
    }
}