using System;

namespace Exercicios02
{
    class Program
    {

        static void Main(string[] args)
        {
            int A, B, C;

            Console.Write("Informe o valor de A: ");
            A = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nInforme o valor de B: ");
            B = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nInforme o valor de C: ");
            C = Convert.ToInt32(Console.ReadLine());

            if (A <= B && B <= C)
            {
                Console.WriteLine("A ordem crescente: {0} {1} {2}", A, B, C);
            }
            else if (A <= C && C <= B)
            {
                Console.WriteLine("A ordem crescente:  {0} {1} {2}", A, C, B);
            }
            else if (B <= A && A <= C)
            {
                Console.WriteLine("A ordem crescente:  {0} {1} {2}", B, A, C);
            }
            else if (B <= C && C <= A)
            {
                Console.WriteLine("A ordem crescente:  {0} {1} {2}", B, C, A);
            }
            else if (C <= A && A <= B)
            {
                Console.WriteLine("A ordem crescente:  {0} {1} {2}", C, A, B);
            }
            else /* C <= B && B < A */
            {
                Console.WriteLine("A ordem crescente:  {0} {1} {2}", C, B, A);
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
