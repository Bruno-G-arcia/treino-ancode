using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercicios.Domain;

namespace Exercicios.Tests
{
    [TestClass] 
    public class ClasseTeste
    {
        [TestMethod]
        public void Testar_Classe()
        {
            string mensagem = MinhaClasse.Olar();
            Assert.AreEqual("Olar", mensagem);
        }
    }
}
