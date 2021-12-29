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
    }
}