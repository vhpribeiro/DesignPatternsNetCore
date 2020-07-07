using System;
using System.Collections.Generic;

namespace ChainOfResponsibility
{
    public class SuporteTIHandler : BaseHandler
    {
        private readonly IList<TiposDeProblema> _tiposDeProblemaSolucionaveis = new List<TiposDeProblema>
        {
            TiposDeProblema.InternetModem
        };
        
        public override void Atender(TiposDeProblema tipoDeProblemaDoCliente)
        {
            Console.WriteLine("Olá, sou o Marcos da equipe de TI aqui da empresa, qual seu problem?");
            if (_tiposDeProblemaSolucionaveis.Contains(tipoDeProblemaDoCliente))
            {
                Console.WriteLine("Muito obrigado cliente, não esqueça de desligar o Team Viewer!");
                return;
            }
            
            _proximoHandler?.Atender(tipoDeProblemaDoCliente);
        }
    }
}