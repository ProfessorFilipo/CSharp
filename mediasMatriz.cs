/*
	Preencha uma matriz de inteiros de dimensão n=5 e m=10 com números aleatórios entre 0 e 100. Em seguida, mostre na tela:
	A matriz.
	A média dos valores na matriz.
	A quantidade de valores acima da média.
	A quantidade dos valores abaixo da média.

*/

using System;

namespace Exercicios02
{
    class Program
    {

        static void Main(string[] args)
        {
            int N = 5, M = 10;
            int[,] Matriz = new int[N, M];
            Random rnd = new Random();
            int media = 0;
            int contAcima = 0, contAbaixo = 0;

            for(int L=0; L<N; L++)
            {
                for(int C=0; C<M; C++)
                {
                    Matriz[L, C] = rnd.Next(100);
                    media += Matriz[L, C];
                    Console.Write("| {0,3} |", Matriz[L, C]);
                }
                Console.WriteLine();
            }
            media /= (N * M);
            Console.WriteLine("\nMédia: {0}", media);

            for (int L = 0; L < N; L++)
            {
                for (int C = 0; C < M; C++)
                {
                    if (Matriz[L, C] > media) contAcima++;
                    if (Matriz[L, C] < media) contAbaixo++;
                }
            }

            Console.WriteLine("{0} valores acima da média!", contAcima);
            Console.WriteLine("{0} valores abaixo da média!", contAbaixo);
            Console.ReadKey();
        }
    }
}
