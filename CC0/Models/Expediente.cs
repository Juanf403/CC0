using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CC0.Models
{
    public class Expediente
    {
        public int ExpedienteId { get; set; }

        //Datos del expediente
        public DateTime FechaExpediente { get; set; }
    
        public int PacienteId { get; set; }
        //ID paciente
        public Paciente Paciente { get; set; }

        //ID de los antecedentes (enfermedades)
        public Antecedente IdAntecedente { get; set; }

        //ID de la alimentacion 
        public int IdAlimentacion { get; set; }

        //Actividad fisica
        public bool RealizaEjercicio { get; set; }
        public string TipoEjercicio { get; set; }
        public string FrecuenciaEjercicio { get; set; }

        //Datos Ginecologicos
        public int Embarazos { get; set; }
        public int Partos { get; set; }
        public int Abortos { get; set; }
        public int Cesareas { get; set; }
        public int PrimerDiaUltimaMenstr{ get; set; }
        public int DuracionMenstruacion{ get; set; }
        public int CicloMenstrual { get; set; }
        public string MetodoAnticon { get; set; }
        public bool TomaHormPast { get; set; }
        public string QueToma { get; set; }

        //Historia Ponderal
        public int PesoMinimo { get; set; }
        public int PesoMaximo { get; set; }
        public bool HaceDieta { get; set; }
        public string MedicoDieta { get; set; }


}
}