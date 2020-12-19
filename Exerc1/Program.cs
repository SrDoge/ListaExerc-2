using System;
using System.Globalization;

namespace Exerc1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Faça um algoritmo que receba os três lados de um triângulo e diga se ele é isósceles, escaleno ou equilátero.
            //•	Equilatero = três lados iguais.
            //•	Isósceles = dois lados iguais
            //•	Escaleno = três lados diferentes

            Console.WriteLine("Informe os dados do triângulo.");
            Console.Write("Lado A: ");
            double la = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Lado B: ");
            double lb = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Lado C: ");
            double lc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (la == lb && lb == lc) Console.WriteLine("Triângulo Equilátero!");
            else if (la == lb || la == lc || lb == lc) Console.WriteLine("Triângulo Isósceles!");
            else Console.WriteLine("Triângulo Escaleno!");
        }
    }
}