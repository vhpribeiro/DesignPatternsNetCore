using System;

namespace Mediator
{
    public class Aviao
    {
        public string NomeDaEmpresa;
        private ITorreDeControleMediator TorreDeControle;
        public Tipo Tipo;
        public bool EstaNoSolo;

        public Aviao(string nomeDaEmpresa, Tipo tipo)
        {
            NomeDaEmpresa = nomeDaEmpresa;
            Tipo = tipo;
            EstaNoSolo = true;
        }

        public void Decolar()
        {
            Console.WriteLine($"{Tipo.ToString()} da empresa {NomeDaEmpresa} decolando.");
            EstaNoSolo = false;
        }

        public void EntrarEmNovoEspacoAereo(TorreDeControle torreDeControle)
        {
            TorreDeControle = torreDeControle;
        }

        public void Aterrizar()
        {
            TorreDeControle.NotificarDescidaDeUmAviao(Tipo);
            EstaNoSolo = true;
            Console.WriteLine($"{Tipo.ToString()} da empresa {NomeDaEmpresa} fazendo aterrizagem.");
        }
    }
}