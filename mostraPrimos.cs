using System;

namespace Exercicios02
{
    class Program
    {

        static bool EhPrimo(int nro)
        {
            bool Dividiu = false;

            for (int i = 2; i < nro; i++)
            {
                if (nro % i == 0)
                {
                    Dividiu = true;
                    break;
                }
            }

            return (!Dividiu);

        }
        static void Main(string[] args)
        {
            int cont=0;
            double media = 0.0;

            Console.WriteLine("::::::::::::::::::::::::::::::::::::");
            Console.WriteLine(":::         Mostra Primos        :::");
            Console.WriteLine("::::::::::::::::::::::::::::::::::::\n");

            for(int i=1; i<=1000;i++) 
            {
                if (EhPrimo(i))
                {
                    media += i;
                    cont++;
                    Console.Write(" {0,3} ", i);
                }
            }

            Console.WriteLine("\nmedia: {0,3}", media / cont);

            Console.ReadKey();
        }
    }
}
