using System;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            var torreDeControle = new TorreDeControle();

            var boeng767DaAzul = new Aviao("Azul", Tipo.Boeing767);
            var boeng767DaGol = new Aviao("Gol", Tipo.Boeing767);
            var a380DaEmirates = new Aviao("Emirates", Tipo.A380);
            var a340DaLatam = new Aviao("Latam", Tipo.A340);

            torreDeControle.RegistrarAvioesQueEstaoNoSolo(boeng767DaAzul);
            torreDeControle.RegistrarAvioesQueEstaoNoSolo(a380DaEmirates);

            boeng767DaGol.Decolar();
            a340DaLatam.Decolar();

            boeng767DaGol.EntrarEmNovoEspacoAereo(torreDeControle);
            boeng767DaGol.Aterrizar();
        }
    }
}
