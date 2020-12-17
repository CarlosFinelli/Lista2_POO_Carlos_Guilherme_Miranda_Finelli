using System;

namespace Questao25
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont1 = 0, cont2 = 0, cont3 = 0, cont4 = 0, cont5 = 0;
            for (int i = 0; i < 15; i++)
            {
                Console.Write("Insira a idade da pessoa: ");
                int idade = Convert.ToInt16(Console.ReadLine());
                Console.Clear();
                if (idade <= 15)
                {
                    cont1++;
                }
                if (idade >= 16 && idade <= 30)
                {
                    cont2++;
                }
                if (idade >= 31 && idade <= 45)
                {
                    cont3++;
                }
                if (idade >= 46 && idade <= 60)
                {
                    cont4++;
                }
                if (idade > 60)
                {
                    cont5++;
                }
            }
            Console.WriteLine($"Até 15 anos: {cont1} \n\nEntre 16 e 30: {cont2} \n\nEntre 31 e 45: {cont3} \n\n" +
                $"Entre 46 e 60: {cont4} \n\nAcima de 61: {cont5}.");
            Console.ReadKey();
        }
    }
}
