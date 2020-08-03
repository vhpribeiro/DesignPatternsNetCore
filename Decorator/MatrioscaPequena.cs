namespace Decorator
{
    public class MatrioscaPequena : Matriosca
    {
        public override string ObterTamanhoDaMatriosca()
        {
            return $"Sou a matriosca pequena";
        }
    }
}