using GestionHojasDeVida.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GestionHojasDeVida.Controllers
{
    public class RegistroUsuarioDTOController : Controller
    {
        RegistroUsuarioDao rudao = new RegistroUsuarioDao();

        // GET: RegistroUsuarioDao
        public ActionResult Index()
        {

            PrecargaCombos();
            return View();
        }

        [HttpPost]
        public ActionResult Registro(RegistroUsuarioDto rudto, string FechaIngreso, string FechaFin, string combocargo, int combocontratos = 0, int comboareas = 0, int combodocu = 0)
        {

            if (ModelState.IsValid)
            {

                int resultado = rudao.InsertUsuario(rudto, combocontratos, comboareas, FechaIngreso, FechaFin, combodocu, combocargo);
                if (resultado == 0)
                {
                    Correo correo = new Models.Correo();
                    correo.enviaEmail();
                    return RedirectToAction("ViewsuccesUsuario", "HojaVidaDto");
                }
                else
                {
                    ModelState.AddModelError("Error", "No se ha registrado el usuario revisar!!!");
                    PrecargaCombos();
                    return View("Index");
                }
            }
            else
            {

                PrecargaCombos();
                return View("Index");
            }

        }

        private void PrecargaCombos()
        {
            var opcion = new TiposDeCargos();
            var comboContratos = new List<ComboTiposContratos>();
            var comboAreas = new List<Areas>();
            var comboDocumentos = new List<Tipos_documento>();
            var comboCargos = new List<TiposDeCargos>();
            comboContratos = rudao.CargaComboContratos();
            comboAreas = rudao.CargaComboAreas();
            comboDocumentos = rudao.CargaComboDocumentos();
            comboCargos = rudao.CargaComboCargos();
            var liscontratos = new SelectList(comboContratos, "Id", "Descripcion");
            var lisareas = new SelectList(comboAreas, "Id", "descripcion");
            var lisdocu = new SelectList(comboDocumentos, "Id", "Descripcion");
            var liscargo = new SelectList(comboCargos, "Descripcion", "Descripcion");
            ViewData["combocontratos"] = liscontratos;
            ViewData["comboareas"] = lisareas;
            ViewData["combodocu"] = lisdocu;
            ViewData["combocargo"] = liscargo;
        }
    }
}