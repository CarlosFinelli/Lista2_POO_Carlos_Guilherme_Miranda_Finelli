using System;

namespace Questao10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira o preço da gasolina (separado por vírgula): ");
            double precoGasolina = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.Write("Insira a o valor a ser pago para abastecer: ");
            double valor = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.WriteLine($"Total de litros abastecidos ao pagar {valor} reais: {Math.Round(valor / precoGasolina, 2)}");
            Console.ReadKey();
        }
    }
}
