using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Exercicios.Domain;

namespace Exercicios.Tests
{
    [TestClass]
    public class HelloWorldTest
    {
        [TestMethod]
        public void SayHelloTest()
        {
            string mensagem = HelloWorld.SayHello();
            Assert.AreEqual("Hello World", mensagem);
            Console.WriteLine(mensagem);    
        }

        [TestMethod]
        public void DiasTempoTeste()
        {
            var agora = DateTime.Now;
            Console.WriteLine(agora);
        }
        [TestMethod]
        public  void DiasTempoModificacoes()
        {
            DateTime agora = DateTime.Parse("31/08/2021");
            Console.WriteLine(agora.AddDays(122));
        }
    }
}