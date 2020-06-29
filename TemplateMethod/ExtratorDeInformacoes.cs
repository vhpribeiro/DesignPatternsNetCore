using System;

namespace TemplateMethod
{
    public abstract class ExtratorDeInformacoes
    {
        public void ExecutarRotinaDeExtracao()
        {
            ExtrairInformacoes();
            SintetizarDados();
            GerarGraficos();
            ConverterPlanilha();
        }
        
        public static void SintetizarDados()
        {
            Console.WriteLine("Sintetizando dados");
        }

        public static void GerarGraficos()
        {
            Console.WriteLine("Gerando gráficos maneiros!");
        }

        public abstract void ExtrairInformacoes();

        public virtual void ConverterPlanilha()
        {
            Console.WriteLine("Convertendo para Excel");
        }
    }
}