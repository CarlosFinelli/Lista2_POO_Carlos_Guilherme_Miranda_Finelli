using System;

namespace Questao4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira o custo de fabricação do carro: ");
            double fabricacao = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            double valorTotal = fabricacao;
            valorTotal += (fabricacao * 28) / 100;
            valorTotal += (fabricacao * 45) / 100;
            Console.WriteLine($"Valor final do carro: {valorTotal}");
            Console.ReadKey();
        }
    }
}
