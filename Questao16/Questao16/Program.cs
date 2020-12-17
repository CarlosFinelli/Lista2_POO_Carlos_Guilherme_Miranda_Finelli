using System;

namespace Questao16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira a sua idade: ");
            int idade = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            if (idade < 18)
            {
                Console.WriteLine("Menor de idade");
                Console.ReadKey();
            } else if (idade >= 18 && idade < 65)
            {
                Console.WriteLine("Maior de idade");
                Console.ReadKey();
            } else if (idade >= 65)
            {
                Console.WriteLine("Idoso(a)");
                Console.ReadKey();
            }
        }
    }
}
