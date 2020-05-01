namespace Mediator
{
    public interface ITorreDeControleMediator
    {
        void RegistrarAvioesQueEstaoNoSolo(Aviao aviao);
        void NotificarDescidaDeUmAviao(Tipo tipo);
    }
}