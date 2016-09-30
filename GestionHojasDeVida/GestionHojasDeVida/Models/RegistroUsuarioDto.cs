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

        [Required(ErrorMessage = "EL campo {0}  no puede estar vacio!!!")]
        [Display(Name ="No. Documento")]
        public int Num_Documento { get; set; }

        [Required(ErrorMessage = "Debe ingresar sus nombres!!")]
        public string Nombres { get; set; }

        [Required(ErrorMessage ="Debe ingresar sus apellidos")]
        public string Apellidos { get; set; }

        [Required(ErrorMessage = "Los apellidos no pueden estar vacios!!!")]
        [Display(Name ="Correo Personal")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Debe ingresar una contraseña valida!!!")]
        [DataType(DataType.Password)]
        [Display(Name ="Contraseña")]
        public string Password { get; set; }

        [Required(ErrorMessage ="Este campo no puede estar vacio!!!")]
        [Display(Name ="Confirmar Contraseña")]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage ="Las contraseñas no coinciden revisar!!")]
        public string ConfirmPass { get; set; }

        public string Cargo { get; set; }

        public int Salario { get; set; }

    }
    
   
}