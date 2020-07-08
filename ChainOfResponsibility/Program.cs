using ChainOfResponsibility.Handlers;

namespace ChainOfResponsibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var atendenteDigitalHandler = new AtendenteDigitalHandler();
            var atendenteFisicoHandler = new AtendenteFisicoHandler();
            var suporteTIHandler = new SuporteTIHandler();

            const TiposDeProblema problema = TiposDeProblema.InternetModem;

            atendenteDigitalHandler.AtribuirProximoHandler(atendenteFisicoHandler);
            atendenteFisicoHandler.AtribuirProximoHandler(suporteTIHandler);

            atendenteDigitalHandler.Atender(problema);
        }
    }
}