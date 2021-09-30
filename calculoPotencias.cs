using System;

namespace Exercicios02
{
    class Program
    {
        static void Main(string[] args)
        {
            int basePotencia;
            int expoente;
            int potencias;
            int cont;

            Console.WriteLine("::::::::::::::::::::::::::::::::::::");
            Console.WriteLine(":::     Calculo de Potencias     :::");
            Console.WriteLine("::::::::::::::::::::::::::::::::::::\n");
            Console.Write("Informe o valor da base: ");
            basePotencia = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nInforme o valor do expoente (positivo): ");
            expoente = Convert.ToInt32(Console.ReadLine());

            potencias = 1;
            cont = 0;

            while(cont != expoente)
            {
                potencias *= basePotencia;
                cont++;
            }

            Console.WriteLine("O valor de {0} elevado a {1} eh igual a {2}", basePotencia, expoente, potencias);


            Console.ReadKey();
        }
    }
}
