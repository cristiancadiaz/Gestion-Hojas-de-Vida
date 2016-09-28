﻿using GestionHojasDeVida.Models;
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
        public ActionResult Registro(RegistroUsuarioDto rudto, string FechaIngreso, string FechaFin, int combocontratos = 0, int comboareas = 0, int combodocu = 0)
        {

            if (ModelState.IsValid)
            {

                int resultado = rudao.InsertUsuario(rudto, combocontratos, comboareas, FechaIngreso, FechaFin, combodocu);
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
                return View("Index");
            }

        }

        private void PrecargaCombos()
        {
            var comboContratos = new List<ComboTiposContratos>();
            var comboAreas = new List<Areas>();
            var comboDocumentos = new List<Tipos_documento>();
            comboContratos = rudao.CargaComboContratos();
            comboAreas = rudao.CargaComboAreas();
            comboDocumentos = rudao.CargaComboDocumentos();
            var liscontratos = new SelectList(comboContratos, "Id", "Descripcion");
            var lisareas = new SelectList(comboAreas, "Id", "descripcion");
            var lisdocu = new SelectList(comboDocumentos, "Id", "Descripcion");
            ViewData["combocontratos"] = liscontratos;
            ViewData["comboareas"] = lisareas;
            ViewData["combodocu"] = lisdocu;
        }
    }
}