using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace CC0.Models
{
    public class Antecedente
    {
        public int AntecedenteId { get; set; }

        //Enfermedades en ambos casos
        public bool Corazon { get; set; }
        public bool PresionAlta { get; set; }
        public bool DiabetesFamiliar { get; set; }
        public bool Tiroides { get; set; }
        public bool Cancer { get; set; }
        public bool Otros { get; set; }

        //Enfermedades en familiares (Padres,Hijos,Abuelos,Hermanos,Ninguno,Paciente)
        public string Familiar { get; set; }
        public bool Infarto { get; set; }
        public bool Obesidad { get; set; }

        //Enfermedades personales
        public bool DiabetesPersonal { get; set; }
        public bool PresionBajaPersonal { get; set; }
        public bool EstreñimientoPersonal { get; set; }
        public bool CirugiaPersonal { get; set; }
        public bool ColesterolPersonal { get; set; }
        public bool AcidoUricoPersonal { get; set; }
        public bool EnfermedadRiñon { get; set; }
        public bool Gastritis { get; set; }
        public bool AlergiasAMedicamentos{ get; set; }
        public bool EnfPsiquiatricas{ get; set; }
        public bool Fuma { get; set; }
        public bool Toma { get; set; }
}

    
}