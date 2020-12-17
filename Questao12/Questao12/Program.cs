using System;

namespace Questao12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira o primeiro valor: ");
            double A = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.Write("Insira o segundo valor: ");
            double B = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            if (B == 0)
            {
                Console.WriteLine("Divisão por Zero.");
                Console.ReadKey();
            } else
            {
                Console.WriteLine($"A divisão entre {A} e {B} é igual a: {A / B}");
            }
        }
    }
}
