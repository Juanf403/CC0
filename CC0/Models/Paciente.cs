using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CC0.Models
{
    public class Paciente
    {
        //ID del paciente
        public int PacienteId { get; set; }
        
        public Expediente IDExpediente { get; set; }

        //Datos del paciente
        //1.Datos Generales

        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public int Edad { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string EstadoCivil { get; set; }
        public string Ocupacion { get; set; }
        public string Direccion { get; set; }
        public string Colonia { get; set; }
        public string Ciudad { get; set; }
        public string TelCasa { get; set; }
        public string TelOficina { get; set; }
        public string CorreoElectronico { get; set; }
        public string Referencia { get; set; }

        
    }
}