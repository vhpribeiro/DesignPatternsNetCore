using FactoryMethod.Carros;

namespace FactoryMethod.Montadoras
{
    public class MontadoraBaseDeCarroEletrico : MontadoraBase
    {
        public bool PossuiSistemaAntiColisao { get; set; }
        public int TempoDeDuracaoEmHoras { get; set; }
        public int AmperagemDaBateria { get; set; }
        public bool PossuiMultimidia { get; set; }

        public MontadoraBaseDeCarroEletrico(int amperagemDaBateria, int tempoDeDuracaoEmHoras,
            bool possuiSistemaAntiColisao)
        {
            AmperagemDaBateria = amperagemDaBateria;
            TempoDeDuracaoEmHoras = tempoDeDuracaoEmHoras;
            PossuiSistemaAntiColisao = possuiSistemaAntiColisao;
        }

        public override Carro Montar()
        {
            return new CarroEletrico("Taycan", AmperagemDaBateria, TempoDeDuracaoEmHoras, PossuiSistemaAntiColisao);
        }
    }
}