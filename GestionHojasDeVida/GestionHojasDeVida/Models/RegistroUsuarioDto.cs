using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GestionHojasDeVida.Models
{
    public class RegistroUsuarioDto
    {
        public int Id { get; set; }
        [Required]
        public int Tipo_Documento { get; set; }
        [Required]
        public int Num_Documento { get; set; }
        [Required]
        public string Nombres { get; set; }
        [Required]
        public string Apellidos { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Direccion { get; set; }
        [Required]
        public int Telefono { get; set; }


    }
}