using System;

namespace Questao31
{
    class Program
    {
        static void Main(string[] args)
        {
            double contIdadeM = 0, contIdadeF = 0, cont1 = 0, cont2 = 0, cont3;
            for (int i = 0; i < 7; i++)
            {
                Console.Write("Insira a idade da pessoa: ");
                int idade = Convert.ToInt16(Console.ReadLine());
                Console.Clear();
                Console.Write("Insira o sexo da pessoa \"M = Masculino, F = Feminino\": ");
                char sexo = Convert.ToChar(Console.ReadLine());
                Console.Clear();
                if (sexo == 'M' || sexo == 'm')
                {
                    contIdadeM += idade;
                    cont1++;
                }
                if (sexo == 'F' || sexo == 'f')
                {
                    contIdadeF += idade;
                    cont2++;
                }
            }
            cont3 = (cont2 + cont1) / 7;
            Console.WriteLine($"Média da idade das mulheres: {contIdadeF / cont2}\n");
            Console.WriteLine($"Média da idade dos homens: {contIdadeM / cont1}\n");
            Console.WriteLine($"Média da idade de todas as pessoas: {cont3}");
        }
    }
}
