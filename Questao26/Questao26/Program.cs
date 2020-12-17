using System;

namespace Questao26
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalV = 0, totalP = 0, total = 0;
            for (int i = 0; i < 15; i++)
            {
                Console.Clear();
                Console.Write("Insira a forma de pagamento que deseja \"V = a vista, P = A prazo\":");
                char opcao = Convert.ToChar(Console.ReadLine());
                Console.Clear();
                if (opcao == 'V' || opcao == 'v')
                {
                    Console.WriteLine("Insira o valor total da compra: ");
                    double valor = Convert.ToDouble(Console.ReadLine());
                    totalV += valor;
                }
                if (opcao == 'P' || opcao == 'p')
                {
                    Console.WriteLine("Insira o valor total da compra: ");
                    double valor = Convert.ToDouble(Console.ReadLine());
                    totalP += valor;
                }
            }
            Console.Clear();
            total = totalP + totalV;
            Console.WriteLine($"Valor total de compras a vista: {totalV}\n");
            Console.WriteLine($"Valor total de compras a prazo: {totalP}\n");
            Console.WriteLine($"Valor total de compras: {total}");
        }
    }
}
