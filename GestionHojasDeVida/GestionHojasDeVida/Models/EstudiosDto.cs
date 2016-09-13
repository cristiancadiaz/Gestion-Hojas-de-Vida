using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestionHojasDeVida.Models
{
    public class EstudiosDto
    {
        public string institucionEducativa { get; set; }
        public string Titulo_obtenido { get; set; }
        public string nvlDeestudio { get; set; }
        public DateTime fechafinalizacion { get; set; }
        public string  Estado { get; set; }


    }
}