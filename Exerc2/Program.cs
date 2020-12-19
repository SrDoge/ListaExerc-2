using System;
using System.Linq;

namespace Exerc2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Faça um algoritmo que receba três números e exiba em ordem crescente.

            int[] num = new int[3];

            for (int i = 0; i < num.Length; i++)
            {
                Console.Write((i + 1) + "º Número: ");
                num[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(string.Join(',', num.OrderBy(s => s)));
        }
    }
}
