using System;

namespace Questao34
{
    class Program
    {
        static void Main(string[] args)
        {
        Inicio:
            Console.Clear();
            Console.Write("Insira o saldo da conta: ");
            double saldo = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.Write("Insira o valor que deseja sacar: ");
            double saque = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            if (saque > saldo)
            {
                Console.WriteLine("O valor de saque não pode ser maior que o saldo da conta.");
                Console.ReadKey();
                goto Inicio;
            } else
            {
                saldo -= saque;
            }
            Console.WriteLine($"Novo saldo da conta: {saldo}");
            Console.ReadKey();
        }
    }
}
