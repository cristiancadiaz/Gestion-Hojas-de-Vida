using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
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
       
        
        public int InsertUsuario(RegistroUsuarioDto rudto, int Tipo_Contrato, int area, string fechaingreso, string fechafin, int Tipo_Documento, string cargo)
        {
            string cadenaConexion = Conexion.constr;
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = cadenaConexion;
            SqlCommand comando = new SqlCommand("SP_INSERTAEMPLEADO", conexion);
            comando.CommandType = CommandType.StoredProcedure;

            SqlParameter TipoContrato = new SqlParameter();
            TipoContrato.ParameterName = "@Tipo_Contrato";
            TipoContrato.SqlDbType = SqlDbType.Int;
            TipoContrato.Value = Tipo_Contrato;

            SqlParameter TipoDocumento = new SqlParameter();
            TipoDocumento.ParameterName = "@Tipo_Documento";
            TipoDocumento.SqlDbType = SqlDbType.VarChar;
            TipoDocumento.Value = Tipo_Documento;

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
            Cargo.Value = cargo;

            SqlParameter Salario = new SqlParameter();
            Salario.ParameterName = "@Salario";
            Salario.SqlDbType = SqlDbType.VarChar;
            Salario.Value = rudto.Salario;

            SqlParameter inArea = new SqlParameter();
            inArea.ParameterName = "@area";
            inArea.SqlDbType = SqlDbType.Int;
            inArea.Value = area;

            SqlParameter infechaIngreso = new SqlParameter();
            infechaIngreso.ParameterName = "@fecha_ingreso";
            infechaIngreso.SqlDbType = SqlDbType.VarChar;
            infechaIngreso.Value = fechaingreso;

           
            comando.Parameters.Add(TipoContrato);
            comando.Parameters.Add(TipoDocumento);
            comando.Parameters.Add(NumDocumento);
            comando.Parameters.Add(Nombres);
            comando.Parameters.Add(Apellidos);
            comando.Parameters.Add(Email);
            comando.Parameters.Add(Password);
            comando.Parameters.Add(Cargo);
            comando.Parameters.Add(Salario);
            comando.Parameters.Add(inArea);
            comando.Parameters.Add(infechaIngreso);
            
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);

            conexion.Open();
           // comando.ExecuteScalar();

            return Convert.ToInt32(comando.ExecuteScalar());

        }
        public List<ComboTiposContratos> CargaComboContratos()
        {
            var lista = new List<ComboTiposContratos>();
            var combo = new ComboTiposContratos();
            string cadenaConexion = Conexion.constr;
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = cadenaConexion;
            string query = "SELECT * FROM TIPO_CONTRATO";
            SqlCommand cmd = new SqlCommand(query, conexion);
            cmd.CommandType = CommandType.Text;
            conexion.Open();

            using (DbDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {

                    lista.Add(new ComboTiposContratos()
                    {
                        Id = Convert.ToInt32(dr["ID_TIPO_CONTRATO"]),
                        Descripcion = Convert.ToString(dr["DESCPR_CONTRATO"]),
                        
                    });


                }
            }

            return lista;
        }
        public List<Areas> CargaComboAreas()
        {
            var lista = new List<Areas>();
            var combo = new Areas();
            string cadenaConexion = Conexion.constr;
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = cadenaConexion;
            string query = "SELECT * FROM AREA";
            SqlCommand cmd = new SqlCommand(query, conexion);
            cmd.CommandType = CommandType.Text;
            conexion.Open();

            using (DbDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {

                    lista.Add(new Areas()
                    {
                        Id = Convert.ToInt32(dr["ID_AREA"]),
                        descripcion = Convert.ToString(dr["DESCRIP_AREA"]),

                    });


                }
            }

            return lista;
        }
        public List<Tipos_documento> CargaComboDocumentos()
        {
            var lista = new List<Tipos_documento>();
            var combo = new Tipos_documento();
            string cadenaConexion = Conexion.constr;
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = cadenaConexion;
            string query = "SELECT * FROM TIPOS_DOCUMENTO";
            SqlCommand cmd = new SqlCommand(query, conexion);
            cmd.CommandType = CommandType.Text;
            conexion.Open();

            using (DbDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {

                    lista.Add(new Tipos_documento()
                    {
                        Id = Convert.ToInt32(dr["TIPO_DOCUMENTO"]),
                        Descripcion = Convert.ToString(dr["DESCRP_DOCUMENTO"]),

                    });


                }
            }

            return lista;
        }
        public List<TiposDeCargos> CargaComboCargos()
        {
            var lista = new List<TiposDeCargos>();
            var combo = new Tipos_documento();
            string cadenaConexion = Conexion.constr;
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = cadenaConexion;
            string query = "SELECT * FROM CARGOS";
            SqlCommand cmd = new SqlCommand(query, conexion);
            cmd.CommandType = CommandType.Text;
            conexion.Open();

            using (DbDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {

                    lista.Add(new TiposDeCargos()
                    {
                        Id = Convert.ToInt32(dr["Id_Cargo"]),
                        Descripcion = Convert.ToString(dr["Cargo"]),

                    });


                }
            }

            return lista;
        }

    }
}