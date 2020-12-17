using System;

namespace Questao6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira o valor que foi depositado na conta: ");
            double valor = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.WriteLine($"Valor após um mês de rendimento: {valor + (valor * 0.02)}");
            Console.ReadKey();
        }
    }
}
