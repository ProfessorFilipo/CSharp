using System;

namespace Exercicios02
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, cont = 0, impar = 1;

            Console.WriteLine("::::::::::::::::::::::::::::::::::::");
            Console.WriteLine("::: Gerador de N numeros impares :::");
            Console.WriteLine("::::::::::::::::::::::::::::::::::::\n");
            Console.Write("Informe o valor de N: ");
            N = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Os primeiros {0} números impares são...", N);
            while(cont < N)
            {
                Console.WriteLine("{0,3}: {1,3}", ++cont, impar);
                impar += 2;
            }

            Console.WriteLine("Pressione qualquer tecla para terminar...");
            Console.ReadKey();
        }
    }
}
