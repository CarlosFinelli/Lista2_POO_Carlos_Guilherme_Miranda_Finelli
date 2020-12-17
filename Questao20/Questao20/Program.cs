using System;

namespace Questao20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira o total de horas trabalhadas do professor (horas quebradas separar por vírgula): ");
            double valor = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.Write("Insira o nivel do professor (1, 2 ou 3):");
            int nivel = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            switch (nivel)
            {
                case 1:
                    double total = valor * 12;
                    Console.WriteLine($"Total a ser pago ao professor: {total}");
                    Console.ReadKey();
                    break;

                case 2:
                    total = valor * 17;
                    Console.WriteLine($"Total a ser pago ao professor: {total}");
                    Console.ReadKey();
                    break;

                case 3:
                    total = valor * 25;
                    Console.WriteLine($"Total a ser pago ao professor: {total}");
                    Console.ReadKey();
                    break;
            }
        }
    }
}
