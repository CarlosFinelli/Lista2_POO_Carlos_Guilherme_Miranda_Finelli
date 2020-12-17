using System;
using System.Collections.Generic;

namespace Questao8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira o preço do produto: ");
            double preco = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.Write("Insira o percentual de acrécimo para venda do produto final (separado por vírgula): ");
            double percentual = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            double total = preco + (percentual * preco);
            Console.WriteLine($"Valor final do produto para o cliente: {total}");
        }
    }
}
