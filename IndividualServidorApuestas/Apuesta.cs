using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IndividualServidorApuestas
{
    public class Apuesta
    {
        public long Id { get; set; }
        public string Tipo { get; set; }
        public float Cuota { get; set; }
        public string Fecha { get; set; }
        public string Evento { get; set; }
        public string Pronostico { get; set; }
        public string DNIUsuario { get; set; }

    }
}