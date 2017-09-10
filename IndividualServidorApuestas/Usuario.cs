using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IndividualServidorApuestas
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }        
        public string Apellidos { get; set; }
        public string DNI { get; set; }
        public string Email { get; set; }
        public string Contrasena { get; set; }
        public string Nick { get; set; }
        public string Cuenta { get; set; }
    }
}