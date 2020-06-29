using System;

namespace TemplateMethod
{
    public class ExtratorDeInformacoesDePdf : ExtratorDeInformacoes
    {
        public override void ExtrairInformacoes()
        {
            Console.WriteLine("Extraindo informações do PDF");
        }
    }
}