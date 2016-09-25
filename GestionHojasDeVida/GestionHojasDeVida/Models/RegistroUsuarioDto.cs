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
        [Required(ErrorMessage = "Este campo no puede estar vacio!!!")]
        [Display(Name ="No. Documento")]
        public int Num_Documento { get; set; }
        [Required(ErrorMessage = "Este campo no puede estar vacio!!!")]
        public string Nombres { get; set; }
        [Required]
        public string Apellidos { get; set; }
        [Required(ErrorMessage = "Este campo no puede estar vacio!!!")]
        [Display(Name ="Correo Personal")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Este campo no puede estar vacio!!!")]
        [DataType(DataType.Password)]
        [Display(Name ="Contraseña")]
        public string Password { get; set; }
        [Required(ErrorMessage ="Este campo no puede estar vacio!!!")]
        [Display(Name ="Confirmar Contraseña")]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPass { get; set; }

        public string Cargo { get; set; }

        public string Salario { get; set; }

    }
    
   
}