using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GestionHojasDeVida.Models
{
    public class InactivarDao
    {
        private string  OnInfoMessage;
        public string InactivarEmpleado(InactivarDto inac)
        {

            string cadenaConexion = Conexion.constr;
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = cadenaConexion;
            SqlCommand comando = new SqlCommand("sp_Inactiva_usuario", conexion);
            comando.CommandType = CommandType.StoredProcedure;

            SqlParameter Identificacion = new SqlParameter();
            Identificacion.ParameterName = "@cedula";
            Identificacion.SqlDbType = SqlDbType.Int;
            Identificacion.Value = inac.Identificacion;

            //SqlParameter Estado = new SqlParameter();
            //Estado.ParameterName = "@estado";
            //Estado.SqlDbType = SqlDbType.VarChar;
            //Estado.Value = inactivo;

            SqlParameter Motivo = new SqlParameter();
            Motivo.ParameterName = "@motivo";
            Motivo.SqlDbType = SqlDbType.VarChar;
            Motivo.Value = inac.Motivo;

            comando.Parameters.Add(Identificacion);
            //comando.Parameters.Add(Estado);
            comando.Parameters.Add(Motivo);

            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            

            conexion.Open();
            // comando.ExecuteScalar();
            return Convert.ToString(comando.ExecuteScalar());
        }

    }

}