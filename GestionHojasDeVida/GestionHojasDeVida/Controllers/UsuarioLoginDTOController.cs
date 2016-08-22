﻿using GestionHojasDeVida.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GestionHojasDeVida.Controllers
{
    public class UsuarioLoginDTOController : Controller
    {
        // objeto de la clase conexion 
        private Conexion DB = new Conexion();

        // GET: UsuarioDTO
        
        public ActionResult Index()
        {
                        
            return View();
        }
        public ActionResult Registro()
        {
            return View();
        }
        public ActionResult Main()
        {
            return View();
        }
        public ActionResult Registro_Completo()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(FormCollection form)
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