using System;

namespace Questao7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira o valor da compra: ");
            double valor = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.WriteLine($"O valor de cada prestação é de: {valor / 5}");
            Console.ReadKey();
        }
    }
}
