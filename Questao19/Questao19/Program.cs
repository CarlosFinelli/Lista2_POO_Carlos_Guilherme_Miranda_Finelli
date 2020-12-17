using System;

namespace Questao19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira o número 1 (inteiro):");
            int num1 = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            Console.Write("Insira o número 2 (inteiro):");
            int num2 = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            Console.Write("Insira o número 3 (inteiro):");
            int num3 = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            if (num1 > num2 && num1 > num3 && num2 > num3)
            {
                Console.WriteLine($"{num3} \n{num2} \n{num1}");
            }

            if (num1 > num2 && num1 > num3 && num2 < num3)
            {
                Console.WriteLine($"{num2} \n{num3} \n{num1}");
            }

            if (num1 < num2 && num2 > num3 && num3 < num1 ) 
            {
                Console.WriteLine($"{num3} \n{num1} \n{num2}");
            }

            if (num1 < num2 && num2 > num3 && num3 > num1)
            {
                Console.WriteLine($"{num1} \n{num3} \n{num2}");
            }

            if (num1 < num2 && num2 < num3)
            {
                Console.WriteLine($"{num1} \n{num2} \n{num3}");
            }

            if (num1 > num2 && num1 < num3)
            {
                Console.WriteLine($"{num2} \n{num1} \n{num3}");
            }
        }
    }
}
