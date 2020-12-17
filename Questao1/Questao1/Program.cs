using System;

namespace Questao1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira o seu nome: ");
            String nome = Console.ReadLine();
            Console.Clear();
            Console.Write("Insira a sua idade: ");
            int idade = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            Console.WriteLine($"{nome}, você já viveu {idade * 365} dias");
        }
    }
}
