using System;

namespace Questao9
{
    class Program
    {
        static void Main(string[] args)
        {
            Padaria padaria = new Padaria();
            Console.Write("Insira o total de pães vendidos no dia: ");
            padaria.pao = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            Console.Write("Insira o total de broas vendidas no dia: ");
            padaria.broa = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            padaria.totalValor = (padaria.pao * 0.12) + (padaria.broa * 1.50);
            Console.WriteLine($"Total arrecadado no dia: {padaria.totalValor}\nTotal para colocar na poupança: {padaria.totalValor * 0.1}");
            Console.ReadKey();
        }
    }
}
