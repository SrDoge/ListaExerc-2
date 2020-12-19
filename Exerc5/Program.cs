using System;

namespace Exerc5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Faça um algoritmo de calculadora.O algoritmo deverá receber um número real, um
            //caractere que representa a operação e outro número real. O resultado da operação entre os
            //dois números deverá ser exibido.

            Console.Write("Primeiro número: ");
            double n1 = double.Parse(Console.ReadLine());

            Console.Write("Informe o operador: ");
            char op = Console.ReadLine()[0];

            Console.Write("Segundo número: ");
            double n2 = double.Parse(Console.ReadLine());

            if (op == '+') Console.WriteLine("Resultado: " + (n1 + n2).ToString("F2"));
            else if (op == '-') Console.WriteLine("Resultado: " + (n1 - n2).ToString("F2"));
            else if (op == '*') Console.WriteLine("Resultado: " + (n1 * n2).ToString("F2"));
            else if (op == '/') Console.WriteLine("Resultado: " + (n1 / n2).ToString("F2"));
            else Console.WriteLine("Operador Inválido!");
        }
    }
}
