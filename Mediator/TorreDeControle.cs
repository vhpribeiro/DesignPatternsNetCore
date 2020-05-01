using System;
using System.Collections.Generic;
using System.Linq;

namespace Mediator
{
    public class TorreDeControle : ITorreDeControleMediator
    {
        private readonly IList<Aviao> _avioesNoSolo = new List<Aviao>();
        public IEnumerable<Aviao> AvioesSolo =>
            _avioesNoSolo;

        public void RegistrarAvioesQueEstaoNoSolo(Aviao aviao) =>
            _avioesNoSolo.Add(aviao);

        public void NotificarDescidaDeUmAviao(Tipo tipo)
        {
            var veiculosDoMesmoTipoDoQueEstaoDescendo =
                _avioesNoSolo.Where(v => v.Tipo == tipo);

            Console.WriteLine($"Liberando espaço para um novo avião do {tipo.ToString()}");

            foreach (var veiculoAereo in veiculosDoMesmoTipoDoQueEstaoDescendo)
                veiculoAereo.Decolar();
        }
    }
}