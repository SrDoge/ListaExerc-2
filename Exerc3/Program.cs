using System;

namespace Exerc3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Faça um algoritmo que leia a idade de um nadador e diga sua categoria:
            //•	Infantil A – 5 até 7 anos;
            //•	Infantil B – 8 até 10 anos;
            //•	Juvenil A – 11 até 13 anos;
            //•	Juvenil B – 14 até 17 anos;
            //•	Sênior – maior de 18 anos;

            Console.WriteLine("Idade do nadador: ");
            int idade = int.Parse(Console.ReadLine());

            if (idade <= 7) Console.WriteLine("Categoria Infantil A");
            else if (idade <= 10) Console.WriteLine("Categoria Infantil B");
            else if (idade <= 13) Console.WriteLine("Categoria Juvenil A");
            else if (idade <= 17) Console.WriteLine("Categoria Juvenil B");
            else Console.WriteLine("Categoria Sênior");
        }
    }
}
