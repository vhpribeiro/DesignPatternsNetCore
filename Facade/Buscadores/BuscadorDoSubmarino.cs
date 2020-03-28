namespace Facade.Buscadores
{
    public class BuscadorDoSubmarino : IBuscador
    {
        public BuscadorDoSubmarino(){ }

        public Livro ObterLivro(string nomeDoLivro)
        {
            //Faz a busca do livro na API do Submarino
            return new Livro("Harry Potter: A Ordem da Fênix", 18.9, "Submarino");
        }
    }
}