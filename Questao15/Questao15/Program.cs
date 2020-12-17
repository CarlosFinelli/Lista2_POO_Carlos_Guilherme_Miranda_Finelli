using System;

namespace Questao15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira o nome do aluno: ");
            String nome = Console.ReadLine();
            Console.Clear();
            Console.Write("Insira a nota 1 do aluno: ");
            double nota1 = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.Write("Insira a nota 2 do aluno: ");
            double nota2 = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.Write("Insira a nota 3 do aluno: ");
            double nota3 = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            double media = (nota1 + nota2 + nota3) / 3;
            if (media >= 7)
            {
                Console.WriteLine($"Situação do aluno {nome}: Aprovado");
                Console.ReadKey();
            } else if (media > 5 && media < 7)
            {
                Console.WriteLine($"Situação do aluno {nome}: Recuperação.");
                Console.ReadKey();
            } else if (media <= 5)
            {
                Console.WriteLine($"Situação do aluno {nome}: Reprovado");
            }
        }
    }
}
