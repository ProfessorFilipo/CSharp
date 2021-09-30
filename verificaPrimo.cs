using System;

namespace Exercicios02
{
    class Program
    {
        static void Main(string[] args)
        {
            int nro;
            bool Dividiu = false;

            Console.WriteLine("::::::::::::::::::::::::::::::::::::");
            Console.WriteLine(":::     Verifica se eh primo     :::");
            Console.WriteLine("::::::::::::::::::::::::::::::::::::\n");
            Console.Write("Informe o numero a ser verificado: ");
            nro = Convert.ToInt32(Console.ReadLine());

            for(int i=2; i<nro; i++)
            {
                if( nro % i ==0)
                {
                    Dividiu = true;
                    break;
                }
            }

            if(Dividiu)
            {
                Console.Write("O numero {0} nao eh primo!", nro);
            }
            else
            {
                Console.Write("O numero {0} eh primo!", nro);
            }

            Console.ReadKey();
        }
    }
}
