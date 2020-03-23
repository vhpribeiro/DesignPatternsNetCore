using FactoryMethod.Carros;

namespace FactoryMethod.Montadoras
{
    public class MontadoraBaseDeCarroACombustao : MontadoraBase
    {
        public string GasEmitente { get; set; }
        public int Autonomia { get; set; }
        public int TamanhoDoTanqueEmLitros { get; set; }

        public MontadoraBaseDeCarroACombustao(int tamanhoDoTanqueEmLitros, int autonomia, string gasEmitente)
        {
            TamanhoDoTanqueEmLitros = tamanhoDoTanqueEmLitros;
            Autonomia = autonomia;
            GasEmitente = gasEmitente;
        }

        public override Carro Montar()
        {
            return new CarroACombustao("911", TamanhoDoTanqueEmLitros, Autonomia, GasEmitente);
        }
    }
}