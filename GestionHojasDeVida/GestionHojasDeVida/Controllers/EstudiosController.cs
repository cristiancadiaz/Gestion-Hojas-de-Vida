using GestionHojasDeVida.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GestionHojasDeVida.Controllers
{
    public class EstudiosController : Controller
    {
        EstudiosDao estud = new EstudiosDao();
        EstudiosNoFormalesDAO estunof = new EstudiosNoFormalesDAO();
        // GET: Estudios
        public ActionResult Estudio()
        {
            return View();
        }

        public ActionResult Estudio_No_Formal()
        {
            PrecargaCombos();
            return View();
        }
        [HttpPost]
        public ActionResult Estudio_No_Formal(EstudiosNoFormalesDTO estudnof)
        {
            if (ModelState.IsValid)
            {

                int resultado = estunof.InsertEdu_NoFormal(estudnof);
                if (resultado == 0)
                {
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
                return View("Estudio_No_Formal");
            }

        }


        // GET: Estudios/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Estudios/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Estudios/Create
        [HttpPost]
        public ActionResult Create(EstudiosDto estdu)
        {

            try
            {
                estud.RegistrarEstudio(estdu);
                ViewBag.mensajeestudios = "Estudios insertados satisfactoriamente";
                return View("Estudio");
            }
            catch (Exception ex)
            {
                ViewBag.mensajeestudios = "No se pudieron regisdtrar los estudios verificar!!!";
                return View("Estudio");
            }
        }

        // GET: Estudios/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Estudios/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Estudios/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Estudios/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        private void PrecargaCombos()
        {
            var comboPaises = new List<Paises>();

            comboPaises = estunof.CargaComboPaises();

            var lisPaises = new SelectList(comboPaises, "PaisCodigo", "PaisNombre");

            ViewData["combopaises"] = lisPaises;

        }
    }
}
