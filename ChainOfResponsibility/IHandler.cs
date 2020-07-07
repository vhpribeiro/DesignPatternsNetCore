namespace ChainOfResponsibility
{
    public interface IHandler
    {
        void AtribuirProximoHandler(IHandler handler);
        void Atender(TiposDeProblema tipoDeProblemaDoCliente);
    }
}