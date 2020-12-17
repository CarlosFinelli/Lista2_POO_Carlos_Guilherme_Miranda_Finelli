using System;

namespace Questao36
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira o salário: ");
            double salario = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.Write("Insira o percentual de reajuste (considere 10% igual a 0,1 \"Separar por vírgulas\"): ");
            double reajuste = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            double total = salario + (salario * reajuste);
            Console.WriteLine($"Salário após o reajuste: {total}");
            Console.ReadKey();
        }
    }
}
