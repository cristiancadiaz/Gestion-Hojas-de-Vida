using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestionHojasDeVida.Models
{
    public class LoginDao : Login
    {

        Conexion con = new Conexion();

        public int Autenticar(string username, string password)
        {
            
           int id = con.EjecutaQuery("SELECT * FROM Clase_Usuario WHERE Usuario = " + "'" + username + "'" + " AND " + "Password = " + "'" + password + "'");
            if(id == 1)
            {
                return 1;
            }
            else
            {
                return 0;
            }
            
        }

        public void Crear()
        {
           
        }
    }
}