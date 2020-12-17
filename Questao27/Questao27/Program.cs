using System;

namespace Questao27
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont1 = 0, cont2 = 0;
            for (int i = 0; i < 25; i++)
            {
                Console.Write("Insira a idade da pessoa: ");
                int idade = Convert.ToInt16(Console.ReadLine());
                Console.Clear();
                Console.Write("Insira o peso dessa pessoa: ");
                double peso = Convert.ToDouble(Console.ReadLine());
                Console.Clear();
                if (peso >= 90)
                {
                    cont1++;
                }
                cont2 += idade;
            }
            Console.WriteLine($"Pessoas com mais de 90 quilos: {cont1}\n");
            Console.WriteLine($"Média de idade das pessoas: {cont2 / 25}");
        }
    }
}
