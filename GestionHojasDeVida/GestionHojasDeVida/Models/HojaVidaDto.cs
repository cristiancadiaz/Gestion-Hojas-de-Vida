using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestionHojasDeVida.Models
{
    public class HojaVidaDto
    {
        public int Id { get; set; }
        public string Tipo_Contrato { get; set; }
        public string Tipo_Documento { get; set; }
        public string Identificacion { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Email { get; set; }
        public string Cargo { get; set; }
        public string Salario { get; set; }
        public string Direccion { get; set; }
        public int Telefono { get; set; }
        public int Celular { get; set; }
        public string perfil_Personal { get; set; }
        public string perfil_Profesional { get; set; }
        public string idiomas { get; set; }
        public string Hobbies { get; set; }
        public string AspiracionSalarial { get; set; }
        public EquivaleteCargo Equivalente_cargo { get; set; }
        public string descrp_area { get; set; }

    }

    public class PerfilProfesional
    {

    }

    public class PerfilPersonal
    {

    }

    public enum EquivaleteCargo
    {
        Asistente_Administrativo,
        Agricultura,
        Recursos_Humanos,
        Tecnologias_de_la_información,
        Analista_de_mercado,
        Fotografia
    }
}