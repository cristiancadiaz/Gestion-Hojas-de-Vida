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

             int resultado = rudao.InsertUsuario(rudto);
                if(resultado == 0)
                {
                    return RedirectToAction("Index", "HojaVidaDto");
                }
                else
                {
                    ModelState.AddModelError("Error", "No se ha registrado el usuario revisar!!!");
                    return View("Index");
                }
            }
            else
            {
                return View("Index");
            }
         
        }
        public ActionResult pruba()
        {
            return View();
        }
    }
}