using System;

namespace Questao11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira o peso (em KG, separado por vírgula) do seu prato: ");
            double prato = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.WriteLine($"Valor total a ser pago: {Math.Round(prato * 12.00, 2)}");
            Console.ReadKey();
        }
    }
}
