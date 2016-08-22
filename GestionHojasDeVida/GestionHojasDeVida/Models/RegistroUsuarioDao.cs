using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.Mvc;

namespace GestionHojasDeVida.Models
{
    public class RegistroUsuarioDao
    {
        Conexion cbd = new Conexion();

        [ValidateAntiForgeryToken]
        public void InsertUsuario()
        {
            cbd.OpenConnection();
            cbd.InsercionRegistro("INSERT INTO Usuario");
        }
    }
}