using System;

namespace Questao30
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 1, cont = 0, contIdade = 0;
            while (idade != 0)
            {
                Console.Write($"Insira a sua idade: ");
                idade = Convert.ToInt16(Console.ReadLine());
                Console.Clear();
                contIdade += idade;
                cont++;
                Console.WriteLine($"Média de idades: {contIdade / cont}");
                Console.ReadKey();
                Console.Clear();
            }
            Console.WriteLine($"Média final: {contIdade / cont}");
            Console.ReadKey();
        }
    }
}
