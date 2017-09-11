using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IndividualServidorApuestas
{
    public class Apuesta
    {
        public long Id { get; set; }
        public string TipoDeporte { get; set; }
        public float Cuota { get; set; }
        public string Fecha { get; set; }
        public string Evento1 { get; set; }
        public string Evento2 { get; set; }
        public string Pronostico { get; set; }
        public string DNIUsuario { get; set; }
        public string AResultado { get; set; }
        public string AVencedor { get; set; }
        public float Cantidad { get; set; }

    }
}