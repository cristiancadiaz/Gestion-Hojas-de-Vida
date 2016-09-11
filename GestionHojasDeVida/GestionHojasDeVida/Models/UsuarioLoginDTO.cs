using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestionHojasDeVida.Models
{
    public class UsuarioLoginDTO
    {
        public string uld_user { get; set; }
        public string uld_pass { get; set; }
        public string Tipo_usuario { get; set; }

        public UsuarioLoginDTO(string User, string Pass)
        {
            this.uld_user = User;
            this.uld_pass = Pass;
        }

    }
}