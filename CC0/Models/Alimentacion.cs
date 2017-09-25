using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CC0.Models
{
    public class Alimentacion
    {
        public int IdAlimentacion { get; set; }

        public string Turno { get; set; }
        public string Horario { get; set; }
        public string Descripcion { get; set; }
    }
}