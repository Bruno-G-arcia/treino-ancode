using Exercicios.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Exercicios.Tests
{
    [TestClass]
    public class DonoTest
    {
        [TestMethod]
        public void Dono_AddPets_Test()
        {
            var leia = new Cachorro { Nome = "Léia" };
            var yuri = new Cachorro { Nome = "Yuri" };
            var tequila = new Cachorro { Nome = "Tequila" };            
            var silvia = new Dono { Nome = "Silvia" };
            var pets = new[] { leia, yuri };
            silvia.AddPet(pets);
            silvia.AddPet(tequila);
            Assert.AreEqual(3, silvia.Pets.Count);
            Assert.AreEqual(silvia, leia.Dono);
            Assert.AreEqual(silvia, yuri.Dono);
            Assert.AreEqual(silvia, tequila.Dono);
            foreach(var pet in silvia.Pets)
            {
                Console.WriteLine(pet.Nome);
            }           

        }
    }
}
