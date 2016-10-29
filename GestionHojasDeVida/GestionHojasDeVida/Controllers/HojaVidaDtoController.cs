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
        public ActionResult ResultadoConsulta(int id)
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

        public ActionResult ConsultaAvanzada()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ConsultaAvanzada(string txtParametro, string txtParametro1, string cmbBuscar,string cmbBuscar1, string cmbFiltro)
        {
            try
            {
                if (cmbFiltro.Equals("null"))
                {

                }
            }
            catch (Exception)
            {
                cmbFiltro = "NINGUNA";
                
            }
            
            
            var ConsultaGrl = new Consulta_General();
            var listado = new List<HojaVidaDto>();

            listado = ConsultaGrl.ConsultaEmpleado(txtParametro,txtParametro1, cmbBuscar, cmbBuscar1, cmbFiltro);


            return View(listado);
        }


        public ActionResult WebForm1()
        {
            return View();
        }
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
    }
}