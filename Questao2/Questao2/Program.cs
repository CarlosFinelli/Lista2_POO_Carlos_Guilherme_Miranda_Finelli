using System;

namespace Questao2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira o total de eleitores: ");
            int total = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            Console.Write("Insira o total de votos brancos: ");
            int brancos = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            Console.Write("Insira o total de votos nulos: ");
            int nulos = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            Console.Write("Insira o total de votos válidos: ");
            int validos = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            Console.WriteLine($"Votos brancos: {(brancos * 100) / total} %\n\n" +
                $"Total de votos nulos: {(nulos * 100) / total} %\n\n" +
                $"Total de votos válidos: {(validos * 100) / total} %");
            Console.ReadKey();
        }
    }
}
