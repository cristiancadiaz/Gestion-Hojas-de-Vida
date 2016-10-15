using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GestionHojasDeVida.Models;

namespace GestionHojasDeVida.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var pruebacorreo = new Correo();
            pruebacorreo.Dispose();
            
        }
    }
}
