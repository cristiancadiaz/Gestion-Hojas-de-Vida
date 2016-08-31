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
        public TipoContrato Tipo_Contrato { get; set; }
        [Required]
        public TipoDocumento Tipo_Documento { get; set; }
        [Required]
        public int Num_Documento { get; set; }
        [Required]
        public string Nombres { get; set; }
        [Required]
        public string Apellidos { get; set; }
        [Required]
        public string Email { get; set; }
        public string Password { get; set; }
        [Required]
        public string ConfirmPass { get; set; }

        public string Cargo { get; set; }

        public string Salario { get; set; }


    }
    public enum TipoContrato
    {
        Indefinido,
        PorObraLabor,
        PrestacionDeServicios
    }
    public enum TipoDocumento
    {
        CedulaDeCiudadania,
        CedulaExtranjeria,
        Pasaporte
    }
}