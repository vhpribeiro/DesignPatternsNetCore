namespace FactoryMethod.Carros
{
    public class CarroACombustao : Carro
    {
        public string GasEmitente { get; set; }
        public int Autonomia { get; set; }
        public int TamanhoDoTanqueEmLitros { get; set; }

        public CarroACombustao(string modelo, int tamanhoDoTanqueEmLitros, int autonomia, string gasEmitente) : base(modelo)
        {
            TamanhoDoTanqueEmLitros = tamanhoDoTanqueEmLitros;
            Autonomia = autonomia;
            GasEmitente = gasEmitente;
        }
    }
}