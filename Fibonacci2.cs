using System;

namespace Exercicios02
{
    class Program
    {

        static void Main(string[] args)
        {

            int N;
            int Fant, Fatual, Fprox, cont;

            Console.Write("\nInforme o valor de N:");
            N = Convert.ToInt32(Console.ReadLine());

            Fant = 0; Fatual = 1; cont = 0;

            while(cont < N)
            {
                Fprox = Fatual + Fant;
                Console.Write(" {0,4}", Fatual);
                Fant = Fatual;
                Fatual = Fprox;
                cont++;

                
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
