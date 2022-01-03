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
            string latido = Cachorro.Latir();
            Console.WriteLine(latido);
            Assert.AreEqual("Bork", latido);
        }
        [TestMethod]
        public void Cachorro_QuantoDevoComer_Test()
        {
            Cachorro leia = new Cachorro();
            string quantoDevoComer = Cachorro.QuantoDevoComer(1);
            Console.WriteLine(quantoDevoComer);
            Assert.AreEqual("Como tenho 1kg, devo comer 50g por dia", quantoDevoComer);
        }
        [TestMethod]
        public void Cachorro_Set_Get_Nome_Teste()
        {
            Cachorro yuri = new Cachorro();
            yuri.Nome = "Yuri";
            Assert.AreEqual("Yuri", yuri.Nome);
            Console.WriteLine(yuri.Nome);
        }
        [TestMethod]
        public void Cachorro_Associacao_Dono_Test()
        {
            var bruno = new Dono
            {
                Nome = "Bruno",
                Telefone = "999999999",
                Email = "garciaBruno@alleanzasistemas.com.br"
            };

            var luma = new Cachorro
            {
                Nome = "Luma",
                Dono = bruno
            };
            Console.WriteLine(luma.Dono.Nome);
        }
        [TestMethod]
        public void Cachorro_Enum_Sexo_test()
        {
            var tequila = new Cachorro
            {
                Nome = "Tequila",
                Sexo = Sexo.Fêmea
            };
            Console.WriteLine(tequila.Sexo);
        }      
    }
}
