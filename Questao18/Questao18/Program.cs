using System;

namespace Questao18
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor = 1;
            while (valor != 0)
            {
                double desconto = 0;
                Console.WriteLine("Digite 0 no valor do carro para encerrar o programa.\n");
                Console.WriteLine("1 - Álcool");
                Console.WriteLine("2 - Gasolina");
                Console.WriteLine("3 - Diesel\n");
                Console.Write("Insira o tipo de combustível que o carro utiliza: ");
                int opcao = Convert.ToInt16(Console.ReadLine());
                Console.Clear();
                Console.Write("Insira o valor do carro: ");
                valor = Convert.ToDouble(Console.ReadLine());
                Console.Clear();
                if (opcao == 1)
                {
                    desconto += valor * 0.25;
                } 
                if (opcao == 2)
                {
                    desconto += valor * 0.21;
                }
                if (opcao == 3)
                {
                    desconto += valor * 0.14;
                }
                Console.WriteLine($"Desconto do carro: {Math.Round(desconto, 2)} \nValor pago pelo cliente: {Math.Round(valor - desconto, 2)}");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
