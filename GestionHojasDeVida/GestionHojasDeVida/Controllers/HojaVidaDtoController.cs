using GestionHojasDeVida.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GestionHojasDeVida.Controllers
{
    public class HojaVidaDtoController : Controller
    {
        HojaVidaDao daohv = new HojaVidaDao();
        // GET: HojaVida
        public ActionResult Index(int id)
        {
            var informacionEmpleado = new HojaVidaDto();
            int numIdentificacion = id;
            TempData["Identificacion"] = id;
            informacionEmpleado = daohv.ConsultaEmpleado(numIdentificacion);

            ViewBag.Tipo_Contrato = informacionEmpleado.Tipo_Contrato;
            ViewBag.Tipo_Documento = informacionEmpleado.Tipo_Documento;
            ViewBag.NumDocumento = informacionEmpleado.Identificacion;
            ViewBag.Nombres = informacionEmpleado.Nombres;
            ViewBag.Apellidos = informacionEmpleado.Apellidos;
            ViewBag.Email = informacionEmpleado.Email;
            ViewBag.Cargo = informacionEmpleado.Cargo;
            ViewBag.Salario = informacionEmpleado.Salario;

            return View();
        }
        [HttpPost]
        public ActionResult ActualizaHV(HojaVidaDto hv)
        {
            int identi = int.Parse(TempData["Identificacion"].ToString());
            daohv.ActualizaHv(hv, identi);
            return View("Experiencia");
        }
        public ActionResult ListadoEmpleados()
        {

            return View();
        }
        
        public ActionResult ConsultaEmpleados()
        {
            
            return View();
        }

        public ActionResult Experiencia()
        {
            return View();
        }

        public ActionResult Estudio()
        {
            return View();
        }
        public ActionResult ViewsuccesUsuario()
        {
            return View();
        }
        public ActionResult Inactivar()
        {
            return View();
        }
        public ActionResult Consulta()
        {
            return View();
        }
    }
}