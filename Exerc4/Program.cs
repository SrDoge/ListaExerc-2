using System;

namespace Exerc4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Faça um algoritmo que leia quatro notas de um aluno e calcule a media. De acordo com a média diga a situação do aluno:
            //•	Média maior ou igual a 7    Aprovado
            //•	Média maior ou igual a 5    Exame
            //•	Média menor que 5       Reprovado

            double[] notas = new double[4];
            double media = 0;

            Console.WriteLine("Informe as notas do aluno.");
            for (int i = 0; i < notas.Length; i++)
            {
                Console.Write(+(i + 1) + "º nota: ");
                notas[i] = double.Parse(Console.ReadLine());
                media += notas[i];
            }

            media /= notas.Length;

            if (media >= 7) Console.WriteLine("Média do aluno: " + media.ToString("F2") + " | situação: APROVADO!");
            else if (media >= 5) Console.WriteLine("Média do aluno: " + media.ToString("F2") + " | situação: EXAME!");
            else Console.WriteLine("Média do aluno: " + media.ToString("F2") + " | situação: REPROVADO!!");
        }
    }
}
