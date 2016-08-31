using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Configuration;
using System.Data.Common;

namespace GestionHojasDeVida.Models
{
    public class Conexion
    {

        public static string constr
        {
            get { return ConfigurationManager.ConnectionStrings["ConexionGestionHv"].ConnectionString; }
        }
        public static string provider
        {
            get { return ConfigurationManager.ConnectionStrings["ConexionGestionHv"].ProviderName; }
        }
        public static DbProviderFactory dpf
        {
            get
            {
                return DbProviderFactories.GetFactory(provider);
            }
        }

    }
}