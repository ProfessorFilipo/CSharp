using System;

namespace Exercicios02
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            int cont;
            int fatorial;

            Console.WriteLine("::::::::::::::::::::::::::::::::::::");
            Console.WriteLine(":::      Calculo de Fatorial     :::");
            Console.WriteLine("::::::::::::::::::::::::::::::::::::\n");
            Console.Write("Informe o valor de N: ");
            N = Convert.ToInt32(Console.ReadLine());

            fatorial = 1;

            for(int i=N; i>1; i--)
            {
                fatorial *= i;
            }

            Console.Write("O fatorial de {0} eh igual a {1}", N, fatorial);

            Console.ReadKey();
        }
    }
}
