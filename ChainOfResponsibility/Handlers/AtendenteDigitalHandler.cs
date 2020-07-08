using System;
using System.Collections.Generic;

namespace ChainOfResponsibility.Handlers
{
    public class AtendenteDigitalHandler : BaseHandler
    {
        private readonly IList<TiposDeProblema> _tiposDeProblemaSolucionaveis = new List<TiposDeProblema>
        {
            TiposDeProblema.SegundaVia,
            TiposDeProblema.NovoPacote
        };
        
        public override void Atender(TiposDeProblema tipoDeProblemaDoCliente)
        {
            Console.WriteLine("Olá sou o João e sou seu atendente digital!");
            if (_tiposDeProblemaSolucionaveis.Contains(tipoDeProblemaDoCliente))
            {
                Console.WriteLine("Muito obrigado pela sua ligação, seu pedido foi atendido com sucesso! Boa noite!");
                return;
            }
            
            Console.WriteLine("Parece que seu problema é muito complexo para mim, irei te encaminhar para um atendente!");
            _proximoHandler?.Atender(tipoDeProblemaDoCliente);
        }
    }
}