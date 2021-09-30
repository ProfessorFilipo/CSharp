using System;

namespace Exercicios02
{
    class Program
    {

        static void Main(string[] args)
        {
            int N;
            Console.WriteLine("Informe o tamanho do vetor: ");
            N = Convert.ToInt32(Console.ReadLine());
            
            int media = 0;
            int maior = -1;
            int menor = N * N;
            int contPares = 0, contImpares = 0;
            int[] Vetor = new int[N];
            Random rnd = new Random();

            for(int i=0; i<N; i++)
            {
                Vetor[i] = rnd.Next(N * 2);
                media += Vetor[i];
                if (Vetor[i] > maior) maior = Vetor[i];
                if (Vetor[i] < menor) menor = Vetor[i];
                if (Vetor[i] % 2 == 0)
                {
                    contPares++;
                } else
                {
                    contImpares++;
                }

                Console.WriteLine("Vetor[{0,2}]: {1,2}", i, Vetor[i]);
            }
            Console.WriteLine("Média: {0}", media / N);
            Console.WriteLine("Maior: {0}\nMenor: {1}", maior, menor);
            Console.WriteLine("Pares: {0}\nImpares: {1}\n", contPares, contImpares);


            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
