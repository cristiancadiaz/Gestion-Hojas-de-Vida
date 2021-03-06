﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Web;

namespace GestionHojasDeVida.Models
{
    public class Consulta_General
    {
        public List<HojaVidaDto> ConsultaEmpleado(string Parametro,string Paramatro1, string Variable, string Variable2, string Sal)
        {

            var objHV = new List<HojaVidaDto>();
            string cadenaConexion = Conexion.constr;
            DbProviderFactory dpf = Conexion.dpf;
            //   SqlConnection con = new SqlConnection();

            // SqlCommand comando = new SqlCommand("mp_TraeInformacionEmpleado", con);
            //   comando.CommandType = CommandType.StoredProcedure;
            string StoredProcedure = "SP_CONSULTA_GENERAL";

            using (DbConnection con = dpf.CreateConnection())
            {
                con.ConnectionString = cadenaConexion;
                using (DbCommand cmd = dpf.CreateCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = StoredProcedure;
                    cmd.CommandType = CommandType.StoredProcedure;
                    //entrada del parametro numero de identificación
                    DbParameter inParametro = cmd.CreateParameter();
                    inParametro.ParameterName = "PARAMETRO";
                    inParametro.Value = Parametro;

                    DbParameter inParametro2 = cmd.CreateParameter();
                    inParametro2.ParameterName = "PARAMETRO2";
                    inParametro2.Value = Paramatro1;

                    DbParameter inVariable = cmd.CreateParameter();
                    inVariable.ParameterName = "VARIABLE";
                    inVariable.Value = Variable;

                    DbParameter inVariable2 = cmd.CreateParameter();
                    inVariable2.ParameterName = "VARIABLE2";
                    inVariable2.Value = Variable2;
                    
                    DbParameter inSal = cmd.CreateParameter();
                    inSal.ParameterName = "SAL";
                    inSal.Value = Sal;


                    cmd.Parameters.Add(inParametro);
                    cmd.Parameters.Add(inParametro2);
                    cmd.Parameters.Add(inVariable);
                    cmd.Parameters.Add(inVariable2);
                    cmd.Parameters.Add(inSal);

                    con.Open();

                    using (DbDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            objHV.Add(new HojaVidaDto()
                            {
                                Identificacion = Convert.ToString(dr["NUM_DOCUMENTO"]),
                                Nombres = Convert.ToString(dr["NOMBRES"]),
                                descrp_area = Convert.ToString(dr["DESCRIP_AREA"]),
                                Cargo = Convert.ToString(dr["CARGO_ACTUAL"]),
                                Salario = Convert.ToString(dr["SALARIO"])

                            });


                        }
                    }
                }
            }


            return objHV;
        }
    }
}