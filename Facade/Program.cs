using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            var buscaDeLivros = new BuscaDeLivros();
            const string nomeDoLivro = "Harry Potter: A Ordem da Fênix";
            const string emailDoUsuario = "testeDeDP@vhpr.com";
            var livrosEncontrados = buscaDeLivros.ObterPorNome(nomeDoLivro, emailDoUsuario);

            Console.WriteLine("Os seguintes livros foram encontrados");
            foreach (var livro in livrosEncontrados)
            {
                Console.WriteLine("{0}, foi encontrado em {1}, custando R${2}", livro.Nome, livro.NomeDaLojaQueEstaSendoVendido, livro.Preco);
            }
        }
    }
}
