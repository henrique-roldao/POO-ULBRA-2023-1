namespace Ativdade_Pessoas
{
    public class Pessoa
    {
        public string nome { get; set; }
        public int idade { get; set; }

        public Pessoa(string nome, int idade=0) {
            this.nome = nome;
            this.idade = idade;
        }

        public void Apresentar() {
            Console.WriteLine($"Olá, meu nome é {nome} e tenho {idade} anos.");
        }
    }
}