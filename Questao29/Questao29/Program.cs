using System;

namespace Questao29
{
    class Program
    {
        static void Main(string[] args)
        {
            int contIdade = 0, contPessoas = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Insira a sua idade: ");
                int idade = Convert.ToInt16(Console.ReadLine());
                Console.Clear();
                Console.Write("Insira a sua altura (em centímetros): ");
                double altura = Convert.ToDouble(Console.ReadLine());
                Console.Clear();
                Console.Write("Insira o seu peso: ");
                double peso = Convert.ToInt16(Console.ReadLine());
                Console.Clear();
                contIdade += idade;
                if (peso >= 90 && altura <= 150)
                {
                    contPessoas++;
                }
            }
            Console.WriteLine($"Média de idade das pessoas: {contIdade / 10}");
            Console.WriteLine($"Pessoas com peso superior a 90 e altura inferior a 150 centímetros: {contPessoas}");
        }
    }
}
