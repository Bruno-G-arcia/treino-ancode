namespace Exercicios.Domain
{
    public class Cachorro
    {
        public string Nome { get; set; } = "";
        public Dono? Dono { get; set; }
        public Sexo? Sexo { get; set; }
        public static string Latir()
        {
            return "Bork";
        }
        public static string QuantoDevoComer(int pesoKg)
        {
            return $"Como tenho {pesoKg}kg, devo comer {pesoKg * 50}g por dia";
        }        
    }
}
