using Exercicios.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Exercicios.Tests
{
    [TestClass] 
    public class cachorroTest
    {
        [TestMethod]
        public void Cachorro_Latir_Test()
        {
            Cachorro leia = new Cachorro();
            string latido = leia.Latir();
            Console.WriteLine(latido);
            Assert.AreEqual("Bork", latido);
        }
        [TestMethod]
        public void Cachorro_QuantoDevoComer_Test()
        {
            Cachorro leia = new Cachorro();
            string quantoDevoComer = leia.QuantoDevoComer(1);
            Console.WriteLine(quantoDevoComer);
            Assert.AreEqual("Como tenho 1kg, devo comer 50g por dia", quantoDevoComer);
        }
        [TestMethod]
        public void Cachorro_Set_Get_Nome_Teste()
        {
            Cachorro yuri = new Cachorro();
            yuri.SetNome("Yuri");
            Assert.AreEqual("Yuri", yuri.GetNome());
            Console.WriteLine(yuri.GetNome());
        }
    }
}
