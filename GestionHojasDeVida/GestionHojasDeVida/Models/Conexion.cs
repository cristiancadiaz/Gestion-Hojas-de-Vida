using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace GestionHojasDeVida.Models
{
    public class Conexion
    {
        // crear la primera conexion 
        protected SqlConnection SqlCon;

        public bool OpenConnection(string Connection = "ConexionGestionHv")
        {
            // aca se conecta a la BD
            SqlCon = new SqlConnection(WebConfigurationManager.ConnectionStrings[Connection].ToString());

            try
            {
                bool Test = true;
                if (SqlCon.State.ToString() == "open")
                {
                    SqlCon.Open();
                }
                return Test;
            }
            catch (Exception Ex)
            {

                return false;
            }

        }
        public bool CloseConnection()
        {
            try
            {
                SqlCon.Close();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        // fin de la conexion
        public int Toint(object s)
        {
            try
            {
                return Int32.Parse(s.ToString());
            }
            catch 
            {

                return 0;
            }
        }

        public int InsercionRegistro(string sql)
        {
            int LastID = 0;
            string query = sql + "SELECT @@Identity;";
            try
            {
                if (SqlCon.State.ToString() == "Open")
                {
                    SqlCommand cmd = new SqlCommand(query, SqlCon);
                    cmd.ExecuteNonQuery();
                    LastID = this.Toint(cmd.ExecuteScalar());
                }
                return this.Toint(LastID);

            }
            catch
            {
                return 0;
            }
           
           
        }
    }
}