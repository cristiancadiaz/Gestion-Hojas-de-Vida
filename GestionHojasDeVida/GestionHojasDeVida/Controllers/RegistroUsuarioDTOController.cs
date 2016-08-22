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
        // GET: RegistroUsuarioDao
        public ActionResult Index()
        {
            return View("Registro");
        }
      
        public ActionResult Registro()
        {
            if(ModelState.IsValid)
            {
                RegistroUsuarioDao rudao = new RegistroUsuarioDao();
            }
            return View("Index");
        }
    }
}