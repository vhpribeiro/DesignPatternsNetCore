namespace TemplateMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var extratorDeInformacoesDePdf = new ExtratorDeInformacoesDePdf();
            extratorDeInformacoesDePdf.ExecutarRotinaDeExtracao();
            
            var extratorDeInformacoesDeDocx = new ExtratorDeInformacoesDeDocx();
            extratorDeInformacoesDeDocx.ExecutarRotinaDeExtracao();
        }
    }
}