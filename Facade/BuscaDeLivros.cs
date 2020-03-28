using Facade.Buscadores;
using System.Collections.Generic;
using System.Linq;

namespace Facade
{
    public class BuscaDeLivros
    {
        public IEnumerable<Livro> ObterPorNome(string nomeDoLivro, string emailDoUsuario)
        {
            var buscadorDaAmazon = new BuscadorDaAmazon();
            var buscadorDaSaraiva = new BuscadorDaSaraiva();
            var buscadorDoSubmarino = new BuscadorDoSubmarino();

            var buscadores = new List<IBuscador>{buscadorDaAmazon, buscadorDoSubmarino, buscadorDaSaraiva};
            var livrosEncontrados = buscadores.Select(buscador => buscador.ObterLivro(nomeDoLivro)).ToList();

            //Salva o histórico de busca do usuário

            //Encaminha para o email os livros encontrados

            return livrosEncontrados;
        }
    }
}