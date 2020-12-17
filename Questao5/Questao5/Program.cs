using System;

namespace Questao5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira o total de carros vendidos pelo vendedor: ");
            int carros = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            Console.Write("Insira o valor total de vendas do vendedor: ");
            double totalVendas = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.Write("Insira o salário do vendedor: ");
            double salario = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.Write("Insira o valor que o vendedor recebe por cada carro vendido: ");
            double valorCarro = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            double valorTotal = salario + (totalVendas * 5) / 100 + (valorCarro * carros);
            Console.WriteLine($"Salário do funcionário: {valorTotal}");
            Console.ReadKey();
        }
    }
}
