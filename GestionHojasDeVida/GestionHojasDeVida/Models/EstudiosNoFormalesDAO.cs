using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GestionHojasDeVida.Models
{
    public class EstudiosNoFormalesDAO
    {
        public List<Paises> CargaComboPaises()
        {
            var lista = new List<Paises>();
            var combo = new Paises();
            string cadenaConexion = Conexion.constr;
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = cadenaConexion;
            string query = "SELECT * FROM PAIS";
            SqlCommand cmd = new SqlCommand(query, conexion);
            cmd.CommandType = CommandType.Text;
            conexion.Open();

            using (DbDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {

                    lista.Add(new Paises()
                    {
                        PaisCodigo = Convert.ToString(dr["PaisCodigo"]),
                        PaisNombre = Convert.ToString(dr["PaisNombre"]),

                    });


                }
            }

            return lista;
        }
        public int InsertEdu_NoFormal(EstudiosNoFormalesDTO estunof)
        {
            string cadenaConexion = Conexion.constr;
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = cadenaConexion;
            SqlCommand comando = new SqlCommand("SP_INSERTA_EDU_NO_FORMAL", conexion);
            comando.CommandType = CommandType.StoredProcedure;

            SqlParameter inIdestudio = new SqlParameter();
            inIdestudio.ParameterName = "@Identificacion";
            inIdestudio.SqlDbType = SqlDbType.Int;
            inIdestudio.Value = estunof.Id_estudioN;

            SqlParameter InEntidad = new SqlParameter();
            InEntidad.ParameterName = "@entidad";
            InEntidad.SqlDbType = SqlDbType.VarChar;
            InEntidad.Value = estunof.Entidad;

            SqlParameter InNom_Curso = new SqlParameter();
            InNom_Curso.ParameterName = "@nom_curso";
            InNom_Curso.SqlDbType = SqlDbType.VarChar;
            InNom_Curso.Value = estunof.Nombre_curso;

            SqlParameter InIntesidad = new SqlParameter();
            InIntesidad.ParameterName = "@intensidad";
            InIntesidad.SqlDbType = SqlDbType.Int;
            InIntesidad.Value = estunof.Intensidad_hora;

            SqlParameter InPais = new SqlParameter();
            InPais.ParameterName = "@id_pais";
            InPais.SqlDbType = SqlDbType.VarChar;
            InPais.Value = estunof.Pais;

            SqlParameter InEstado = new SqlParameter();
            InEstado.ParameterName = "@estado";
            InEstado.SqlDbType = SqlDbType.VarChar;
            InEstado.Value = estunof.Estado_estudio;

            SqlParameter InFecha = new SqlParameter();
            InFecha.ParameterName = "@fecha";
            InFecha.SqlDbType = SqlDbType.VarChar;
            InFecha.Value = estunof.Fecha_fin;

            SqlParameter InRuta = new SqlParameter();
            InRuta.ParameterName = "@ruta";
            InRuta.SqlDbType = SqlDbType.VarChar;
            InRuta.Value = estunof.Path_anexos;


            comando.Parameters.Add(inIdestudio);
            comando.Parameters.Add(InEntidad);
            comando.Parameters.Add(InNom_Curso);
            comando.Parameters.Add(InIntesidad);
            comando.Parameters.Add(InPais);
            comando.Parameters.Add(InEstado);
            comando.Parameters.Add(InFecha);
            comando.Parameters.Add(InRuta);

            SqlDataAdapter adaptador = new SqlDataAdapter(comando);

            conexion.Open();
            // comando.ExecuteScalar();

            return Convert.ToInt32(comando.ExecuteScalar());
        }
    }
}