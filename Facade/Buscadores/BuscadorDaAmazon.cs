namespace Facade.Buscadores
{
    public class BuscadorDaAmazon : IBuscador
    {
        public BuscadorDaAmazon(){ }

        public Livro ObterLivro(string nomeDoLivro)
        {
            //Faz a busca do livro na API da Amazon
            return new Livro("Harry Potter: A Ordem da Fênix", 25.8, "Amazon");
        }
    }
}