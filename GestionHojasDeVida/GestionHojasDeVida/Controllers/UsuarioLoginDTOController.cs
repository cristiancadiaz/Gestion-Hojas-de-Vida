using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GestionHojasDeVida.Controllers
{
    public class UsuarioLoginDTOController : Controller
    {
        // GET: UsuarioDTO
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Registro()
        {
            return View();
        }
        [HttpPost]
        public ActionResult create()
        {
            return View();
        }
        public ActionResult Delete(int Id)
        {
            return View();
        }
        [HttpPost]
        public ActionResult Update(int Id)
        {
            return View();
        }
        public ActionResult Read(int Id)
        {
            return View();
        }
    }
}