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
    }
}