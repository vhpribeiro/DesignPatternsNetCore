using FactoryMethod.Montadoras;

namespace FactoryMethod
{
    public class MontadoraDeCarroFactory
    {
        public static MontadoraBase CriarMontadora(TipoDeCarro tipoDeCarro)
        {
            switch (tipoDeCarro)
            {
                case TipoDeCarro.Eletrico : return new MontadoraBaseDeCarroEletrico(150000, 5, true);
                case TipoDeCarro.Combustao : return new MontadoraBaseDeCarroACombustao(55, 12, "CO2");
                case TipoDeCarro.Vapor : return new MontadoraBaseDeCarroAVapor(200, 5, 20);
            }

            return default;
        }
    }
}