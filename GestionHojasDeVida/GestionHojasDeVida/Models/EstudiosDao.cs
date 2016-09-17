using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GestionHojasDeVida.Models
{
    public class EstudiosDao
    {
        public int RegistrarEstudio(EstudiosDto rutd)
        {
            string cadenaConexion = Conexion.constr;
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = cadenaConexion;
            SqlCommand comando = new SqlCommand("SP_InsertarEstudio", conexion);
            comando.CommandType = CommandType.StoredProcedure;

            SqlParameter Institucion = new SqlParameter();
            Institucion.ParameterName = "@Institucion";
            Institucion.SqlDbType = SqlDbType.Int;
            Institucion.Value = rutd.institucionEducativa;

            SqlParameter Titulo = new SqlParameter();
            Titulo.ParameterName = "@Titulo";
            Titulo.SqlDbType = SqlDbType.Int;
            Titulo.Value = rutd.Titulo_obtenido;

            SqlParameter NivelEstudio = new SqlParameter();
            Titulo.ParameterName = "@NivelEstudio";
            Titulo.SqlDbType = SqlDbType.Int;
            Titulo.Value = rutd.nvlDeestudio;

            SqlParameter FechaFinalizacion = new SqlParameter();
            FechaFinalizacion.ParameterName = "@FechaFinalizacion";
            FechaFinalizacion.SqlDbType = SqlDbType.Int;
            FechaFinalizacion.Value = rutd.fechafinalizacion;

            SqlParameter Estado = new SqlParameter();
            Estado.ParameterName = "@Estado";
            Estado.SqlDbType = SqlDbType.Int;
            Estado.Value = rutd.Estado;

            comando.Parameters.Add(Institucion);
            comando.Parameters.Add(Titulo);
            comando.Parameters.Add(NivelEstudio);
            comando.Parameters.Add(FechaFinalizacion);
            comando.Parameters.Add(Estado);

            SqlDataAdapter adaptador = new SqlDataAdapter(comando);

            conexion.Open();
            // comando.ExecuteScalar();
            //cambios

            return Convert.ToInt32(comando.ExecuteScalar());
        }
    }
}