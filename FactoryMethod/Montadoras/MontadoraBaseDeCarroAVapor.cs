using FactoryMethod.Carros;

namespace FactoryMethod.Montadoras
{
    public class MontadoraBaseDeCarroAVapor : MontadoraBase
    {
        public int PesoDaCaldeira { get; set; }
        public int Autonomia { get; set; }
        public int TamanhoDoTanqueEmLitros { get; set; }

        public MontadoraBaseDeCarroAVapor(int tamanhoDoTanqueEmLitros, int autonomia, int pesoDaCaldeira)
        {
            TamanhoDoTanqueEmLitros = tamanhoDoTanqueEmLitros;
            Autonomia = autonomia;
            PesoDaCaldeira = pesoDaCaldeira;
        }

        public override Carro Montar()
        {
            return new CarroAVapor("Stanley Steam Car", TamanhoDoTanqueEmLitros, Autonomia, PesoDaCaldeira, 39);
        }
    }
}