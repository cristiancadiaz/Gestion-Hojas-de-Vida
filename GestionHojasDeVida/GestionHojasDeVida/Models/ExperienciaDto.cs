using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace GestionHojasDeVida.Models
{
    public class ExperienciaDto
    {
        public string Empresa { get; set; }
        public string Cargo { get; set; }
        [Display(Name = "Fecha Inicio", Description = "Describa sus funciones y logros")]
        public DateTime fechaInicio { get; set; }
        [Display(Name = "Fecha Fin", Description = "Describa sus funciones y logros")]
        public DateTime FechaFin { get; set; }
        [Display(Name = "Funciones y Logros", Description = "Describa sus funciones y logros")]
        public string fun_logros { get; set; }
    }
}