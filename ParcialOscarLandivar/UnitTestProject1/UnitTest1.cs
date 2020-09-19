using System;
using System.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParcialOscarLandivar.Controllers;

namespace UnitTestPregunta1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodGet()
        {
            //Arrange
            PaisesController paisesController = new PaisesController();

            //Act
            var Resultado = paisesController.GetPaises();

            //Assert
            Assert.IsNotNull(Resultado);

        }
    }
}