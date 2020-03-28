namespace Facade.Buscadores
{
    public class BuscadorDaSaraiva : IBuscador
    {
        public BuscadorDaSaraiva() { }

        public Livro ObterLivro(string nomeDoLivro)
        {
            //Faz a busca do livro na API da Saraiva
            return new Livro("Harry Potter: A Ordem da Fênix", 23.5, "Saraiva");
        }
    }
}