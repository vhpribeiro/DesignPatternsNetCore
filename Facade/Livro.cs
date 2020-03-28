namespace Facade
{
    public class Livro
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public string NomeDaLojaQueEstaSendoVendido { get; set; }

        public Livro(string nome, double preco, string nomeDaLoja)
        {
            Nome = nome;
            Preco = preco;
            NomeDaLojaQueEstaSendoVendido = nomeDaLoja;
        }
    }
}