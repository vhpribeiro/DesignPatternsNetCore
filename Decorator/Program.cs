using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            var matriocaPequena = new MatrioscaPequena();
            var matrioscaMedia = new MatrioscaMedia(matriocaPequena);
            var matrioscaGrande = new MatrioscaGrande(matrioscaMedia);
            
            Console.WriteLine(matrioscaGrande.ObterTamanhoDaMatriosca());
        }
    }
}