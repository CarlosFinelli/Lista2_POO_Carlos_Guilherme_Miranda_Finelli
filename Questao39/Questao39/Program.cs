using System;

namespace Questao39
{
    class Program
    {
        static void Main(string[] args)
        {
            Inicio:
            Console.Write("Digite uma idade: ");
            int idade = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            // condicional if else
            if (idade < 18)
            {
                Console.WriteLine("Menor de idade");
            } else
            {
                Console.WriteLine("Maior de idade");
            }
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("1 -Voltar para o início.");
            Console.WriteLine("2 - Encerrar o programa.");
            Console.Write("\nDigite a opção que deseja: ");
            int opcao = Convert.ToInt16(Console.ReadLine());
            // condicional switch case
            switch (opcao)
            {
                case 1:
                    goto Inicio;

                case 2:
                    break;
            }
        }
    }
}
