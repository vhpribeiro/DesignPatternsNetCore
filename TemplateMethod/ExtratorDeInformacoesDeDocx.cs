using System;

namespace TemplateMethod
{
    public class ExtratorDeInformacoesDeDocx : ExtratorDeInformacoes
    {
        public override void ExtrairInformacoes()
        {
            Console.WriteLine("Extraindo informações de um Documento Word");
        }

        public override void ConverterPlanilha()
        {
            Console.WriteLine("Convertendo para arquivo .csv");
        }
    }
}