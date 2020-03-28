namespace Facade.Buscadores
{
    public interface IBuscador
    {
        Livro ObterLivro(string nomeDoLivro);
    }
}