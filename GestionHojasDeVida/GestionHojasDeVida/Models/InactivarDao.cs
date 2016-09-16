using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestionHojasDeVida.Models
{
    public class InactivarDao
    {
        public int Autenticar(string username, string password)

        {
            SqlParameter Identificacion = new SqlParameter();
            Identificaciono.ParameterName = "@Identificacion";
            Identificacion.SqlDbType = SqlDbType.Int;
            Identificacion.Value = rudto.identificacion;

            SqlParameter Estado = new SqlParameter();
            Estado.ParameterName = "@Estado";
            Estado.SqlDbType = SqlDbType.VarChar;
            Estado.Value = rudto.Estado;

            SqlParameter Motivo = new SqlParameter();
            Motivo.ParameterName = "@Motivo";
            Motivo.SqlDbType = SqlDbType.VarChar;
            Motivo.Value = rudto.Motivo;
        }
        public void Inactivar()
        { }
    }
    
}