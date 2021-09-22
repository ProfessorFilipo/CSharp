using System;
					
public class Program
{
	public static void Main()
	{
		int N = 20;
		int[] Valores = new int[N];
		int i, posicao;
		bool Achei;
		Random rnd = new Random();
		
		
		posicao = 0;
		while( posicao < N )
		{
			Achei = false;
			int valor = rnd.Next(N*N);
			
			for(i=0; i<posicao; i++)
			{
				if( valor == Valores[i] ) Achei = true;
			}
			
			if(!Achei)
			{
				Valores[posicao] = valor;
				posicao++;
			}
		}
	
		Array.Sort(Valores);
		for(i=0; i<N; i++)
		{
			string Dados = String.Format("Valores[{0,2}]: {1,2}", i, Valores[i]);
			Console.WriteLine(Dados);
		}
		
	}
}
