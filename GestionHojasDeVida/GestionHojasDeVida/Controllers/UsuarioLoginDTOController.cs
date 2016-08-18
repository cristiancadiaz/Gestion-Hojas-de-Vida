using GestionHojasDeVida.Models;
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
        [HttpPost]
        public ActionResult Registro(FormCollection form)
        {
            var username = form["TextUser"];
            var password = form["TextPassword"];
            var logindto = new UsuarioLoginDTO(username,password);
            var logindao = new LoginDao();
            logindao.Autenticar(logindto.uld_user,logindto.uld_pass);
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