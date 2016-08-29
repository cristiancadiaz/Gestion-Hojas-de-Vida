using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.Mvc;

namespace GestionHojasDeVida.Models
{
    
    public class RegistroUsuarioDao
    {
        //RegistroUsuarioDto rudto = new RegistroUsuarioDto();
       
        
        public int InsertUsuario(RegistroUsuarioDto rudto)
        {
            string cadenaConexion = Conexion.constr;
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = cadenaConexion;
            SqlCommand comando = new SqlCommand("SP_INSERTAUSUARIO", conexion);
            comando.CommandType = CommandType.StoredProcedure;

            SqlParameter TipoContrato = new SqlParameter();
            TipoContrato.ParameterName = "@Tipo_Contrato";
            TipoContrato.SqlDbType = SqlDbType.VarChar;
            TipoContrato.Value = rudto.Tipo_Contrato;

            SqlParameter TipoDocumento = new SqlParameter();
            TipoDocumento.ParameterName = "@Tipo_Documento";
            TipoDocumento.SqlDbType = SqlDbType.VarChar;
            TipoDocumento.Value = rudto.Tipo_Documento;

            SqlParameter NumDocumento = new SqlParameter();
            NumDocumento.ParameterName = "@Numero_Documento";
            NumDocumento.SqlDbType = SqlDbType.Int;
            NumDocumento.Value = rudto.Num_Documento;

            SqlParameter Nombres = new SqlParameter();
            Nombres.ParameterName = "@Nombres";
            Nombres.SqlDbType = SqlDbType.VarChar;
            Nombres.Value = rudto.Nombres;

            SqlParameter Apellidos = new SqlParameter();
            Apellidos.ParameterName = "@Apellidos";
            Apellidos.SqlDbType = SqlDbType.VarChar;
            Apellidos.Value = rudto.Apellidos;

            SqlParameter Email = new SqlParameter();
            Email.ParameterName = "@Email";
            Email.SqlDbType = SqlDbType.VarChar;
            Email.Value = rudto.Email;

            SqlParameter Password = new SqlParameter();
            Password.ParameterName = "@Password";
            Password.SqlDbType = SqlDbType.VarChar;
            Password.Value = rudto.Password;

            SqlParameter Cargo = new SqlParameter();
            Cargo.ParameterName = "@Cargo";
            Cargo.SqlDbType = SqlDbType.VarChar;
            Cargo.Value = rudto.Cargo;

            SqlParameter Salario = new SqlParameter();
            Salario.ParameterName = "@Salario";
            Salario.SqlDbType = SqlDbType.VarChar;
            Salario.Value = rudto.Salario;

            comando.Parameters.Add(TipoContrato);
            comando.Parameters.Add(TipoDocumento);
            comando.Parameters.Add(NumDocumento);
            comando.Parameters.Add(Nombres);
            comando.Parameters.Add(Apellidos);
            comando.Parameters.Add(Email);
            comando.Parameters.Add(Password);
            comando.Parameters.Add(Cargo);
            comando.Parameters.Add(Salario);

            SqlDataAdapter adaptador = new SqlDataAdapter(comando);

            conexion.Open();
           // comando.ExecuteScalar();

            return Convert.ToInt32(comando.ExecuteScalar());

        }
    }
}