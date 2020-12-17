using System;

namespace Questao23
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 15; i++)
            {
                double desconto = 0;
                Console.Write("Insira o nome do cliente: ");
                String nome = Console.ReadLine();
                Console.Clear();
                Console.Write("Insira o valor das compras desse cliente no ano passado: ");
                double valor = Convert.ToDouble(Console.ReadLine());
                Console.Clear();
                if (valor < 1000.00)
                {
                    desconto = valor * 0.1;
                } else
                {
                    desconto = valor * 0.15;
                }
                Console.WriteLine($"{nome}, você possui um bônus de R$ {Math.Round(desconto, 2)} na nossa loja.");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
