using System;

namespace Questao3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira o salário atual do funcionário: ");
            double salario = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.Write("Insira o valor de reajuste (com separação por vírgula): ");
            double reajuste = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            reajuste /= 100;
            double novoSalario = salario + (salario * reajuste);
            Console.WriteLine($"Salário final do funcionário: {novoSalario}");
        }
    }
}
