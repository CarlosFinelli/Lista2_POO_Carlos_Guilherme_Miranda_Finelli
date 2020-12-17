using System;

namespace Questao14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            double num = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            if (num >= 100 && num <= 200)
            {
                Console.WriteLine("Este número está no intervalo entre 100 e 200");
                Console.ReadKey();
            } else
            {
                Console.WriteLine("Este número não está no intervalo entre 100 e 200");
                Console.ReadKey();
            }
        }
    }
}
