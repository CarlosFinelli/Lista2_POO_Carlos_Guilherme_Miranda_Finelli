using System;

namespace Questao24
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 0, idade;
            for (int i = 0; i < 50; i++)
            {
                Console.Write("Insira a idade da pessoa: ");
                idade = Convert.ToInt16(Console.ReadLine());
                Console.Clear();
                if (idade >= 18)
                {
                    cont++;
                }
            }
            Console.WriteLine($"O total de pessoas com idade maior ou igual a 18 é: {cont}");
            Console.ReadKey();
        }
    }
}
