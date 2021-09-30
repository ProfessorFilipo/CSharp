/*
  	Monte uma matriz quadrada (n x n) preenchida com valores aleatórios entre 0 e (n^2). O valor de n deve ser solicitado ao usuário. A seguir, mostre na tela:
	A matriz.
	A média dos valores da matriz.
	O maior valor.
	O menor valor.
	O somatório dos valores na diagonal principal.
	O somatório dos valores na diagonal secundária.
*/

using System;

namespace Exercicios02
{
    class Program
    {

        static void Main(string[] args)
        {
            int N;
            Console.WriteLine("Informe o valor de N: ");
            N = Convert.ToInt32(Console.ReadLine());

            int[,] Matriz = new int[N, N];
            Random rnd = new Random();
            int media = 0, maior = -1, 
                menor = N * N, 
                acumDiagPrincipal = 0, 
                acumDiagSecundaria = 0;

            for(int L=0; L<N; L++)
            {
                for(int C=0; C<N; C++)
                {
                    Matriz[L, C] = rnd.Next(N * N);
                    media += Matriz[L, C];
                    if (Matriz[L, C] > maior) maior = Matriz[L, C];
                    if (Matriz[L, C] < menor) menor = Matriz[L, C];
                    Console.Write("| {0,3} |", Matriz[L, C]);
                }
                Console.WriteLine();

                acumDiagPrincipal += Matriz[L, L];
                acumDiagSecundaria += Matriz[L, N - L - 1];

            }

            Console.WriteLine("Media dos valores: {0}", media/(N*N));
            Console.WriteLine("Maior valor: {0}", maior);
            Console.WriteLine("Menor valor: {0}", menor);
            Console.WriteLine("Somatorio Diagonal Principal: {0}", acumDiagPrincipal);
            Console.WriteLine("Somatorio Diagonal Secundária: {0}", acumDiagSecundaria);

            Console.ReadKey();
        }
    }
}
