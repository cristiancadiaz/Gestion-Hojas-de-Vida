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
        //RegistroUsuarioDto rudto = new RegistroUsuarioDto();
        Conexion cbd = new Conexion();

        [ValidateAntiForgeryToken]
        public void InsertUsuario(RegistroUsuarioDto rudto)
        {
            cbd.OpenConnection();
            cbd.EjecutaQuery("INSERT INTO Usuario(tipoDocumento,numDocumento,nombres,apellidos,correo,contraseña,direccion,telefono) VALUES('"+rudto.Tipo_Documento +"','"+ rudto.Num_Documento+"','"+ rudto.Nombres +"','"+ rudto.Apellidos+"','"+ rudto.Email+"','"+
                                  rudto.Password+"','"+ rudto.Direccion+"','"+ rudto.Telefono+"')");
        }
    }
}