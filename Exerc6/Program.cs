using System;

namespace Exerc6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Faça um algoritmo que calcule o gasto em reais de combustível de um automóvel em um determinado percurso. 
            //O algoritmo deverá receber o tipo de combustível utilizado, álcool ou gasolina.O consumo de combustível do automóvel por Km e o número de km a ser percorrido.
            //Considerar:
            //•	Litro de álcool R$1.09
            //•	Litro de gasolina R$1.46

            double gasto = 0;

            Console.WriteLine("Tipo de combustível: 1 - Álcool | 2 - Gasolina ");
            char tipo = Console.ReadLine()[0];

            Console.Write("Quantos KM por litro: ");
            double km = double.Parse(Console.ReadLine());

            Console.Write("Percurso total em KM: ");
            double per = double.Parse(Console.ReadLine());

            if (tipo == '1')
            {
                gasto = (per / km) * 1.09;
                Console.WriteLine("Gasto total na viagem: R$" + gasto.ToString("F2"));
            }
            else if (tipo == '2')
            {
                gasto = (per / km) * 1.46;
                Console.WriteLine("Gasto total na viagem: R$" + gasto.ToString("F2"));
            }
            else Console.WriteLine("Tipo de combustível não encontrado.");
        }
    }
}
