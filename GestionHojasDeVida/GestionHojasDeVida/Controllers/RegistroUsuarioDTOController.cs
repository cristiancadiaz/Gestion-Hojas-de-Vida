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
            return View();
        }

        [HttpPost]
        public ActionResult Registro(RegistroUsuarioDto rudto)
        {

            if (ModelState.IsValid)
            {

               rudao.InsertUsuario(rudto);
            }
            return View("Index");
        }
        public ActionResult pruba()
        {
            return View();
        }
    }
}