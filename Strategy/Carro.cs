using System;

namespace Strategy
{
    public class Carro : Automovel
    {
        public int ProximaManutencao;
        public int KmAtual => 50000;

        public override void FazerManutencao()
        {
            TrocarCorreaDentada();
            TrocarFiltroDoAr();
            TrocarOleo();
            ProximaManutencao = KmAtual + 10000;
            Console.WriteLine("Concertei um carro");
        }

        private static void TrocarOleo()
        {
            //Troca o oléo
        }

        private static void TrocarFiltroDoAr()
        {
            //Troca o filtro do ar
        }

        private static void TrocarCorreaDentada()
        {
            //Troca a correa dentada
        }
    }
}