namespace Decorator
{
    public class MatrioscaGrande : Matriosca
    {
        public Matriosca MatrioscaFilha { get; set; }
        
        public MatrioscaGrande(Matriosca matrioscaFilha)
        {
            MatrioscaFilha = matrioscaFilha;
        }

        public override string ObterTamanhoDaMatriosca()
        {
            return $"Sou uma matriosca grande -> {MatrioscaFilha.ObterTamanhoDaMatriosca()}";
        }
    }
}