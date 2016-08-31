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
        public ActionResult Registro()
        {


            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Datos(RegistroUsuarioDto rudto)
        {
            if(ModelState.IsValid)
            {
                
                rudao.InsertUsuario(rudto);
            }
            return View("Registro");
        }
    }
}