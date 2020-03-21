using System;

namespace Strategy
{
    public class Caminhao : Automovel
    {
        public int ProximaManutencao;
        public int KmAtual => 50000;

        public override void FazerManutencao()
        {
            TrocarTodosFiltros();
            TrocarPneus();
            Rebalancear();
            TrocarPastilhasDeFreios();
            ProximaManutencao = KmAtual + 50000;
            Console.WriteLine("Concertei um caminhão");
        }

        private static void TrocarPastilhasDeFreios()
        {
            //Trocar todas as pastilhas de freios
        }

        private static void Rebalancear()
        {
            //Fazer o rebalanceamento dos pneus
        }

        private static void TrocarPneus()
        {
            //Trocar todos os pneus
        }

        private static void TrocarTodosFiltros()
        {
            //Trocar todos os filtros que o caminhão possui
        }
    }
}