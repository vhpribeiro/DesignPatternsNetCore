using System;
using Adapter.Adapter;
using Adapter.Target;

namespace Adapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEmpregado empregado = new EmpregadoAdapter();
            string valor = empregado.ObterTodosEmpregados();
            Console.WriteLine(valor);
        }
    }
}