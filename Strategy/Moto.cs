using System;

namespace Strategy
{
    public class Moto : Automovel
    {
        public int ProximaManutencao;
        public int KmAtual => 50000;
        public override void FazerManutencao()
        {
            TrocarCorrea();
            TrocarOleo();
            TrocarPistao();
            ProximaManutencao = KmAtual + 5000;
            Console.WriteLine("Concertei uma moto");
        }

        private static void TrocarPistao()
        {
            //Troca o pistao
        }

        private static void TrocarOleo()
        {
            //Troca o oléo
        }

        private static void TrocarCorrea()
        {
            //Troca a correa
        }
    }
}