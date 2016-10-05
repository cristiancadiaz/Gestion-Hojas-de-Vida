using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GestionHojasDeVida.Models
{
    public class EstudiosNoFormalesDTO
    {
        public int Id_estudioN { get; set; }
        public string Entidad { get; set; }
        public string Nombre_curso { get; set; }
        public int Intensidad_hora { get; set; }
        public Paises Pais { get; set; }
        public estado Estado_estudio { get; set; }
        public DateTime Fecha_fin { get; set; }
        public string Path_anexos { get; set; }


        public enum estado
        {
            No_Culminado,
            En_Curso,
            Finalizado
        }
        
    }
}