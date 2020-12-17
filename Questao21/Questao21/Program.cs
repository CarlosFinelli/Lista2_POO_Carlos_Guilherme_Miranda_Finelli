using System;

namespace Questao21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira a idade do nadador: ");
            int idade = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            if (idade >= 5 && idade <= 7)
            {
                Console.WriteLine("Infantil A");
                Console.ReadLine();
            }
            if (idade >= 8 && idade <= 10)
            {
                Console.WriteLine("Infantil B");
                Console.ReadLine();
            }
            if (idade >= 11 && idade <= 13)
            {
                Console.WriteLine("Juvenil A");
                Console.ReadLine();
            }
            if (idade >= 14 && idade <= 17)
            {
                Console.WriteLine("Juvenil B");
                Console.ReadLine();
            }
            if (idade >= 18 && idade <= 25)
            {
                Console.WriteLine("Sênior");
                Console.ReadKey();
            } else if (idade < 5 || idade > 25)
            {
                Console.WriteLine("Idade fora da faixa etária");
                Console.ReadKey();
            }
        }
    }
}
