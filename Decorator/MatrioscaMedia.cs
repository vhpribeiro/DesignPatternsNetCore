namespace Decorator
{
    public class MatrioscaMedia : Matriosca
    {
        public Matriosca MatrioscaFilha { get; set; }
        
        public MatrioscaMedia(Matriosca matrioscaFilha)
        {
            MatrioscaFilha = matrioscaFilha;
        }
        
        public override string ObterTamanhoDaMatriosca()
        {
            return $"Sou a matriosca média -> {MatrioscaFilha.ObterTamanhoDaMatriosca()}";
        }
    }
}