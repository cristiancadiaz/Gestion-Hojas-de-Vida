using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GestionHojasDeVida.Models
{
    public class ExperienciaDao
    {
        public int RegistrarExperiencia(ExperienciaDto rutd)
        {
            string cadenaConexion = Conexion.constr;
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = cadenaConexion;
            SqlCommand comando = new SqlCommand("SP_InsertarExperiencia", conexion);
            comando.CommandType = CommandType.StoredProcedure;

            SqlParameter Empresa = new SqlParameter();
            Empresa.ParameterName = "@Empresa";
            Empresa.SqlDbType = SqlDbType.VarChar;
            Empresa.Value = rutd.Empresa;

            SqlParameter Cargo = new SqlParameter();
            Cargo.ParameterName = "@Cargo";
            Cargo.SqlDbType = SqlDbType.VarChar;
            Cargo.Value = rutd.Cargo;

            SqlParameter Fecha_Inicio = new SqlParameter();
            Fecha_Inicio.ParameterName = "@Fecha_Inicio";
            Fecha_Inicio.SqlDbType = SqlDbType.VarChar;
            Fecha_Inicio.Value = rutd.FechaFin;

            SqlParameter Fecha_Fin = new SqlParameter();
            Fecha_Fin.ParameterName = "@Fecha_Fin";
            Fecha_Fin.SqlDbType = SqlDbType.VarChar;
            Fecha_Fin.Value = rutd.FechaFin;

            SqlParameter Funciones_Logros = new SqlParameter();
            Funciones_Logros.ParameterName = "@Funciones_Logros";
            Funciones_Logros.SqlDbType = SqlDbType.VarChar;
            Funciones_Logros.Value = rutd.fun_logros;

            comando.Parameters.Add(Empresa);
            comando.Parameters.Add(Cargo);
            comando.Parameters.Add(Fecha_Inicio);
            comando.Parameters.Add(Fecha_Fin);
            comando.Parameters.Add(Funciones_Logros);

            SqlDataAdapter adaptador = new SqlDataAdapter(comando);

            conexion.Open();
            // comando.ExecuteScalar();
            //cambios

            return Convert.ToInt32(comando.ExecuteScalar());
        }
    }
}