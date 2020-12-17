using System;

namespace Questao13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira o seu peso (em KG, separado por vírgula): ");
            double Kilos = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.WriteLine($"O seu peso em kilos é igual a: {Kilos * 1000} gramas");
        }
    }
}
