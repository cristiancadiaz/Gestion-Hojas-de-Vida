using GestionHojasDeVida.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GestionHojasDeVida.Controllers
{
    public class InactivarController : Controller
    {
        // GET: Inactivar
        public ActionResult Inactivar()
        {
            return View();
        }

        // GET: Inactivar/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Inactivar/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Inactivar/Create
        [HttpPost]
        public ActionResult Create(InactivarDto inac)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Inactivar/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Inactivar/Edit/5
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

        // GET: Inactivar/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Inactivar/Delete/5
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
