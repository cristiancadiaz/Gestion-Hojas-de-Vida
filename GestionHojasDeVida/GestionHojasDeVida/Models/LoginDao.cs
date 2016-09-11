using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GestionHojasDeVida.Models
{
    public class LoginDao : Login
    {

        public int Autenticar(string username, string password)
        {

            string cadenaConexion = Conexion.constr;
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = cadenaConexion;
            SqlCommand comando = new SqlCommand("sp_ConfirmaUsuario", conexion);
            comando.CommandType = CommandType.StoredProcedure;

            SqlParameter valUsername = new SqlParameter();
            valUsername.ParameterName = "@usuario";
            valUsername.SqlDbType = SqlDbType.VarChar;
            valUsername.Value = username;

            SqlParameter valPassword = new SqlParameter();
            valPassword.ParameterName = "@Password";
            valPassword.SqlDbType = SqlDbType.VarChar;
            valPassword.Value = password;

            comando.Parameters.Add(valUsername);
            comando.Parameters.Add(valPassword);

            SqlDataAdapter adaptador = new SqlDataAdapter(comando);

            conexion.Open();
            // comando.ExecuteScalar();

            return Convert.ToInt32(comando.ExecuteScalar());
        }

        public void Crear()
        {

        }
    }
}