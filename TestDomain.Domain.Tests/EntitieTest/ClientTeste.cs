using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using TestDomain.Domain.Entities;

namespace TestDomain.Domain.Tests.EntitieTest
{
    [TestClass]
    public class ClientTeste
    {
        public string nome { get; private set; }
        public string sobrenome { get; private set; }
        public string idade { get; private set; }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ifNullorEmpty()
        {
            Client.IsNullOrEmpty(null);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ifLenghtUltrapassed()
        {
            Client.ValidateMaxLengh("fdsfsdfsdfsdfsdfsdjndkajsdaasdalsjalsjkdlçkakdjadaldjkdkaskdlasjdakladjad");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ifMinLenghtNotUltrapassed()
        {
            Client.ValidateMinLenght("as");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ifAgeLenghtUltrapassed()
        {
            Client.ValidadeMaxAge("1234");
        }
    }
}
