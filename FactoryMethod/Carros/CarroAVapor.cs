namespace FactoryMethod.Carros
{
    public class CarroAVapor : Carro
    {
        public int MaiorVelocidadeRegistradaEmKmPorHora { get; set; }
        public int PesoDaCaldeira { get; set; }
        public int Autonomia { get; set; }
        public int TamanhoDoTanqueEmLitros { get; set; }

        public CarroAVapor(string modelo, int tamanhoDoTanqueEmLitros, int autonomia,
            int pesoDaCaldeira, int maiorVelocidadeRegistradaEmKmPorHora) : base(modelo)
        {
            TamanhoDoTanqueEmLitros = tamanhoDoTanqueEmLitros;
            Autonomia = autonomia;
            PesoDaCaldeira = pesoDaCaldeira;
            MaiorVelocidadeRegistradaEmKmPorHora = maiorVelocidadeRegistradaEmKmPorHora;
        }
    }
}