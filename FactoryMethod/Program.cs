using System;
using System.Collections.Generic;
using FactoryMethod.Montadoras;

namespace FactoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var montadoraDeCarrosEletricos = MontadoraDeCarroFactory.CriarMontadora(TipoDeCarro.Eletrico);
            var montadoraDeCarrosACombustao = MontadoraDeCarroFactory.CriarMontadora(TipoDeCarro.Combustao);
            var montadoraDeCarrosAVapor = MontadoraDeCarroFactory.CriarMontadora(TipoDeCarro.Vapor);

            var montadoras = new List<MontadoraBase>
            {
                montadoraDeCarrosAVapor, montadoraDeCarrosACombustao, montadoraDeCarrosEletricos
            };

            foreach (var montadora in montadoras)
            {
                var carroMontado = montadora.Montar();
                Console.WriteLine("O carro montado foi do tipo {0} e o modelo foi {1}", carroMontado.GetType(), carroMontado.Modelo);
            }
        }
    }
}
