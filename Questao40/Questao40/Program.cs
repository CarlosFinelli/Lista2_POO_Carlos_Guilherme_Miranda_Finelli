using System;

namespace Questao40
{
    class Program
    {
        static void Main(string[] args)
        {
            ImprimeMensagem texto = new ImprimeMensagem();
            Console.WriteLine(texto.imprimeMensagem());
            Console.ReadKey();
        }
    }
}
