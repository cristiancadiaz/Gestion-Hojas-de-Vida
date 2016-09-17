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
        public int InactivarEmpleado(InactivarDto inac,int inactivo)
        {

            string cadenaConexion = Conexion.constr;
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = cadenaConexion;
            SqlCommand comando = new SqlCommand("SP_InactivarEmpleado", conexion);
            comando.CommandType = CommandType.StoredProcedure;

            SqlParameter Identificacion = new SqlParameter();
            Identificacion.ParameterName = "@Identificacion";
            Identificacion.SqlDbType = SqlDbType.Int;
            Identificacion.Value = inac.Identificacion;

            SqlParameter Estado = new SqlParameter();
            Estado.ParameterName = "@Estado";
            Estado.SqlDbType = SqlDbType.Int;
            Estado.Value = inactivo;

            SqlParameter Motivo = new SqlParameter();
            Motivo.ParameterName = "@Motivo";
            Motivo.SqlDbType = SqlDbType.VarChar;
            Motivo.Value = inac.Motivo;

            comando.Parameters.Add(Identificacion);
            comando.Parameters.Add(Estado);
            comando.Parameters.Add(Motivo);

            SqlDataAdapter adaptador = new SqlDataAdapter(comando);


            conexion.Open();
            // comando.ExecuteScalar();
            return Convert.ToInt32(comando.ExecuteScalar());
        }

    }

}