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
        public int Autenticar(InactivarDto rudto)
        {

            string cadenaConexion = Conexion.constr;
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = cadenaConexion;
            SqlCommand comando = new SqlCommand("SP_InactivarEmpleado", conexion);
            comando.CommandType = CommandType.StoredProcedure;

            SqlParameter Identificacion = new SqlParameter();
            Identificacion.ParameterName = "@Identificacion";
            Identificacion.SqlDbType = SqlDbType.Int;
            Identificacion.Value = rudto.Identificacion;

            SqlParameter Estado = new SqlParameter();
            Estado.ParameterName = "@Estado";
            Estado.SqlDbType = SqlDbType.VarChar;
            Estado.Value = rudto.Estado;

            SqlParameter Motivo = new SqlParameter();
            Motivo.ParameterName = "@Motivo";
            Motivo.SqlDbType = SqlDbType.VarChar;
            Motivo.Value = rudto.Motivo;

            comando.Parameters.Add(Identificacion);
            comando.Parameters.Add(Estado);
            comando.Parameters.Add(Motivo);

            SqlDataAdapter adaptador = new SqlDataAdapter(comando);

            conexion.Open();
            // comando.ExecuteScalar();

            return Convert.ToInt32(comando.ExecuteScalar());
        }
        public void Inactivar()
        { }
    }
    
}