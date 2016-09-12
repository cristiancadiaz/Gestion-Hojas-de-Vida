using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GestionHojasDeVida.Models
{
    public class HojaVidaDao
    {

        public HojaVidaDto ConsultaEmpleado(int numIdentificacion)
        {

            var objHV = new HojaVidaDto();
            string cadenaConexion = Conexion.constr;
            DbProviderFactory dpf = Conexion.dpf;
            //   SqlConnection con = new SqlConnection();

            // SqlCommand comando = new SqlCommand("mp_TraeInformacionEmpleado", con);
            //   comando.CommandType = CommandType.StoredProcedure;
            string StoredProcedure = "mp_TraeInformacionEmpleado";

            using (DbConnection con = dpf.CreateConnection())
            {
                con.ConnectionString = cadenaConexion;
                using (DbCommand cmd = dpf.CreateCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = StoredProcedure;
                    cmd.CommandType = CommandType.StoredProcedure;
                    //entrada del parametro numero de identificación
                    DbParameter numeroIdentificacion = cmd.CreateParameter();
                    numeroIdentificacion.ParameterName = "num_identificacion";
                    numeroIdentificacion.Value = numIdentificacion;
                    cmd.Parameters.Add(numeroIdentificacion);

                    con.Open();

                    using (DbDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {

                            objHV.Tipo_Contrato = Convert.ToString(dr["Tipo_Contrato"]);
                            objHV.Tipo_Documento = Convert.ToString(dr["Tipo_Documento"]);
                            objHV.Identificacion = Convert.ToString(dr["Num_Documento"]);
                            objHV.Nombres = Convert.ToString(dr["Nombres"]);
                            objHV.Apellidos = Convert.ToString(dr["Apellidos"]);
                            objHV.Email = Convert.ToString(dr["Email"]);
                            objHV.Cargo = Convert.ToString(dr["Cargo"]);
                            objHV.Salario = Convert.ToString(dr["Salario"]);


                        }
                    }
                }
            }


            return objHV;
        }

        internal int ActualizaHv(HojaVidaDto hv,int Identificacion)
        {
            string cadenaConexion = Conexion.constr;
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = cadenaConexion;
            SqlCommand comando = new SqlCommand("SP_ActualizaHV", conexion);
            comando.CommandType = CommandType.StoredProcedure;

            SqlParameter Identifiacion = new SqlParameter();
            Identifiacion.ParameterName = "@Identificacion";
            Identifiacion.SqlDbType = SqlDbType.VarChar;
            Identifiacion.Value = Identificacion;

            SqlParameter Direccion = new SqlParameter();
            Direccion.ParameterName = "@direccion";
            Direccion.SqlDbType = SqlDbType.VarChar;
            Direccion.Value = hv.Direccion;

            SqlParameter Telefono = new SqlParameter();
            Telefono.ParameterName = "@telefono";
            Telefono.SqlDbType = SqlDbType.Int;
            Telefono.Value = hv.Telefono;

            SqlParameter Celular = new SqlParameter();
            Celular.ParameterName = "@celular";
            Celular.SqlDbType = SqlDbType.VarChar;
            Celular.Value = hv.Celular;

            SqlParameter Perfil_personal = new SqlParameter();
            Perfil_personal.ParameterName = "@perfil_personal";
            Perfil_personal.SqlDbType = SqlDbType.VarChar;
            Perfil_personal.Value = hv.perfil_Personal;

            SqlParameter Aspi_sala = new SqlParameter();
            Aspi_sala.ParameterName = "@aspiracion_salarial";
            Aspi_sala.SqlDbType = SqlDbType.VarChar;
            Aspi_sala.Value = hv.AspiracionSalarial;

            SqlParameter equi_cargo = new SqlParameter();
            equi_cargo.ParameterName = "@equiva_cargo";
            equi_cargo.SqlDbType = SqlDbType.VarChar;
            equi_cargo.Value = hv.Equivalente_cargo;

            SqlParameter per_profe = new SqlParameter();
            per_profe.ParameterName = "@perfil_profe";
            per_profe.SqlDbType = SqlDbType.VarChar;
            per_profe.Value = hv.perfil_Profesional;

            SqlParameter Hobbies = new SqlParameter();
            Hobbies.ParameterName = "@Hobbies";
            Hobbies.SqlDbType = SqlDbType.VarChar;
            Hobbies.Value = hv.Hobbies;

            comando.Parameters.Add(Identifiacion);
            comando.Parameters.Add(Direccion);
            comando.Parameters.Add(Telefono);
            comando.Parameters.Add(Celular);
            comando.Parameters.Add(Perfil_personal);
            comando.Parameters.Add(Aspi_sala);
            comando.Parameters.Add(equi_cargo);
            comando.Parameters.Add(per_profe);
            comando.Parameters.Add(Hobbies);

            SqlDataAdapter adaptador = new SqlDataAdapter(comando);

            conexion.Open();
            // comando.ExecuteScalar();

            return Convert.ToInt32(comando.ExecuteScalar());
        }
    }
}