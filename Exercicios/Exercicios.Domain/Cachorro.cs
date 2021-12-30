using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Domain
{
    public class Cachorro
    {
        private string _nome    = "";
        private string _sexo    = "";
        private string _raca    = "";
        private string _porte   = "";
        private int    _idade;
        private double _peso;


        public string Latir()
        {
            return "Bork";
        }
        public string QuantoDevoComer(int pesoKg)
        {
            return $"Como tenho {pesoKg}kg, devo comer {pesoKg * 50}g por dia";
        }

        public void SetNome(string nome)
        {
            _nome = nome;
        }

        public object GetNome()
        {
            return _nome;
        }
    }
}
