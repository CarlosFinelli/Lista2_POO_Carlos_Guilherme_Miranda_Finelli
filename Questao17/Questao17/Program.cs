using System;

namespace Questao17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o seu nome: ");
            String nome = Console.ReadLine();
            Console.Clear();
            Console.Write("Insira o sexo \"M = Masculino, F = Feminino\": ");
            char sexo = Convert.ToChar(Console.ReadLine());
            Console.Clear();
            if (sexo == 'M')
            {
                Console.WriteLine($"Nome: {nome} | Sexo: Masculino");
                Console.ReadKey();
            } else if (sexo == 'F')
            {
                Console.WriteLine($"Nome: {nome} | Sexo: Feminino");
                Console.ReadKey();
            }
        }
    }
}
