﻿using GestionHojasDeVida.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GestionHojasDeVida.Controllers
{
    public class ExperienciaController : Controller
    {
        ExperienciaDao expdao = new ExperienciaDao();
        // GET: Experiencia
        public ActionResult Experiencia()
        {
            return View();
        }

        // GET: Experiencia/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Experiencia/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Experiencia/Create
        [HttpPost]
        public ActionResult Create(ExperienciaDto expdto)
        {

            // aca se llama un objeto de tipo Experiencia Dao que es el que genera las consultas e inserta la experiencia
            try
            {
                expdao.RegistrarExperiencia(expdto);
                ViewBag.MensajeExistoso = "Experiencia agregada satisfactoriamente";
                return View("Experiencia");
            }
            catch
            {
                ViewBag.MensajeExistoso = "La experiencia no pudo ser registrada verifique!!!";
                return View("Experiencia");
            }
        }

        // GET: Experiencia/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Experiencia/Edit/5
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

        // GET: Experiencia/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Experiencia/Delete/5
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
    }
}
