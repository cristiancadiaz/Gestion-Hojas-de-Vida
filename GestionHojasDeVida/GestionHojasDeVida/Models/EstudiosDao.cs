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
            Institucion.ParameterName = "@Institudion_educativa";
            Institucion.SqlDbType = SqlDbType.VarChar;
            Institucion.Value = rutd.institucionEducativa;

            SqlParameter Titulo = new SqlParameter();
            Titulo.ParameterName = "@Titulo_Obtenido";
            Titulo.SqlDbType = SqlDbType.VarChar;
            Titulo.Value = rutd.Titulo_obtenido;

            SqlParameter NivelEstudio = new SqlParameter();
            NivelEstudio.ParameterName = "@Nvl_d_estudio";
            NivelEstudio.SqlDbType = SqlDbType.VarChar;
            NivelEstudio.Value = rutd.nvlDeestudio;

            SqlParameter FechaFinalizacion = new SqlParameter();
            FechaFinalizacion.ParameterName = "@FechaFin";
            FechaFinalizacion.SqlDbType = SqlDbType.VarChar;
            FechaFinalizacion.Value = rutd.fechafinalizacion;

            SqlParameter Estado = new SqlParameter();
            Estado.ParameterName = "@Estado";
            Estado.SqlDbType = SqlDbType.VarChar;
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