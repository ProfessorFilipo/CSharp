using System;
					
public class Program
{
	public static void Main()
	{
		int N = 10;
		int[] Numeros = new int[N];
		Random rnd = new Random();
		
		for(int i=0; i<N; i++)
		{
			Numeros[i] = rnd.Next(N);
			Console.WriteLine("Numeros[{0}]: {1}", i, Numeros[i]);
		}
	}
}
