using System;
using System.Collections.Generic;

namespace ChainOfResponsibility
{
    public class AtendenteFisicoHandler : BaseHandler
    {
        private readonly IList<TiposDeProblema> _tiposDeProblemaSolucionaveis = new List<TiposDeProblema>
        {
            TiposDeProblema.Tv,
            TiposDeProblema.InternetConexao
        };
        
        public override void Atender(TiposDeProblema tipoDeProblemaDoCliente)
        {
            Console.WriteLine("Olá sou o Vitor e tentarei te ajudar com seu problema!");
            if (_tiposDeProblemaSolucionaveis.Contains(tipoDeProblemaDoCliente))
            {
                Console.WriteLine("Muito obrigado cliente, fico feliz por solucionar o seu problema." +
                                  " Ao encerrar essa chamada deixe seu feedback sobre meu atendimento!");
                return;
            }
            
            Console.WriteLine("Peço perdão por não conseguir lhe ajudar, irei te encaminhar para outro setor.");
            _proximoHandler?.Atender(tipoDeProblemaDoCliente);
        }
    }
}