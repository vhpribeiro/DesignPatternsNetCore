namespace FactoryMethod.Carros
{
    public class Carro
    {
        public string Modelo { get; set; }

        public Carro(string modelo)
        {
            Modelo = modelo;
        }
    }
}