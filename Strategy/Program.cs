using System.Collections.Generic;

namespace Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var carroDoJoao = new Carro();
            var motoDoLuis = new Moto();
            var caminhaoDaAna = new Caminhao();
            var veiculosParaRealizarManutencao = new List<Automovel>
            {
                caminhaoDaAna, carroDoJoao, motoDoLuis
            };

            foreach (var veiculoParaRealizarManutencao in veiculosParaRealizarManutencao)
            {
                veiculoParaRealizarManutencao.FazerManutencao();
            }
        }
    }
}
