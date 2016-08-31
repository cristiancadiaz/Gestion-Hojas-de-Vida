﻿using GestionHojasDeVida.Models;
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
        public ActionResult Index()
        {
            var informacionEmpleado = new HojaVidaDto();
            int numIdentificacion = 80858465;
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

            return View();
        }

    }
}