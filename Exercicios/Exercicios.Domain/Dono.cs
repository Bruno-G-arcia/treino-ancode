namespace Exercicios.Domain
{
    public class Dono
    {
        public string Nome { get; set; } = "";
        public string Telefone { get; set; } = "";
        public string Email { get; set; } = "";
        public List<Cachorro> Pets { get; set; } = new List<Cachorro>();
        
        public void AddPet(params Cachorro[] pets)
        {
            foreach (var pet in pets)
            {
                Pets.Add(pet);
                pet.Dono = this;
            }
        }
    }
}
