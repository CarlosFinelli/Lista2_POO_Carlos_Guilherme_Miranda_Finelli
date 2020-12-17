using System;

namespace Questao33
{
    class Program
    {
        static void Main(string[] args)
        {
            double cont = 0;
            for (int i = 0; i < 4; i++)
            {
                Console.Write($"Insira a nota {i + 1}: ");
                double nota = Convert.ToDouble(Console.ReadLine());
                Console.Clear();
                cont += nota;
            }
            Console.WriteLine($"A média das notas é igual a: {cont / 4}");
            Console.ReadKey();
        }
    }
}
