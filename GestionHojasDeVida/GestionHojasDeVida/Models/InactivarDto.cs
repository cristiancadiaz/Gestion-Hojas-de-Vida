using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestionHojasDeVida.Models
{
    public class InactivarDto
    {
        public int Identificacion { get; set; }
        public string Estado { get; set; }
        public string Motivo { get; set; }
    }


}