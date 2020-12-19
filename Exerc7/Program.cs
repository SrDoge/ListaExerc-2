using System;
using System.Linq;
using System.Globalization;

namespace Exerc7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Faça um algoritmo que calcule o gasto em reais com tijolos para se construir uma parede. 
            //O algoritmo deverá receber a largura e a altura da parede e o tipo de tijolo a ser utilizado.
            //Considerando os três tipos de tijolos abaixo:

            Console.WriteLine("Tijolo A: (Largura x Altura) 0,50 x 0,30 | R$20,00 ");
            Console.WriteLine("Tijolo B: (Largura x Altura) 0,40 x 0,30 | R$18,00 ");
            Console.WriteLine("Tijolo C: (Largura x Altura) 0,35 x 0,20 | R$12,00 ");
            Console.WriteLine("");

            double gasto;

            Console.WriteLine("Tipo de tijolo: A | B | C ");
            char tipo = Console.ReadLine()[0];

            Console.Write("Largura da parede: ");
            double larg = double.Parse(Console.ReadLine());

            Console.Write("Altura da parede: ");
            double alt = double.Parse(Console.ReadLine());

            if (Char.ToUpper(tipo) == 'A')
            {
                gasto = ((larg * alt) / (0.50 * 0.30)) * 1.1;
                gasto *= 20;
                Console.WriteLine("Gasto total com tijolos do tipo A: R$" + gasto.ToString("F2"));
            }
            else if (Char.ToUpper(tipo) == 'B')
            {
                gasto = ((larg * alt) / (0.40 * 0.30)) * 1.1;
                gasto *= 18;
                Console.WriteLine("Gasto total com tijolos do tipo B: R$" + gasto.ToString("F2"));
            }
            else if (Char.ToUpper(tipo) == 'C')
            {
                gasto = ((larg * alt) / (0.35 * 0.20)) * 1.1;
                gasto *= 12;
                Console.WriteLine("Gasto total com tijolos do tipo C: R$" + gasto.ToString("F2"));
            }
            else
            {
                Console.WriteLine("Tipo de tijolo não encontrado.");
            }

        }
    }
}
