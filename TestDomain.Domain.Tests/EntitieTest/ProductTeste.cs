using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TestDomain.Domain.Entities;

namespace TestDomain.Domain.Tests.EntitieTest
{
    [TestClass]
    public class ProductTeste
    {
        public string nome { get; private set; }
        public string fornecedor { get; private set; }
        public string marca { get; private set; }
        public decimal valor { get; private set; }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void isNullOrEmpty()
        {
            Product.ifNullOrEmpty("");
        }
        
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void maxLenghtUltrapassed()
        {
            Product.maxLenghtPassed("fklkajldkjakldjasldjkalsjdkajskdjaskjdaskdkasjdaskdasdkla");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void minLenghtUltrapassed()
        {
            Product.minLenghtNotPassed("s");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void valueImpassed()
        {
            Product.minValue(0);
        }
    }
}
