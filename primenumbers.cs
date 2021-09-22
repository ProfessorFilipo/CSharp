using System;
					
public class Program
{
	public static void Main()
	{

		int N=1000, nro=2, cont=0;
		
		while(cont<N)
		{
			bool Dividiu = false;
			for(int i = 2; i<nro; i++)
			{
				if(nro % i == 0)
				{
					Dividiu = true;
					break;
				}
			}
			
			if(!Dividiu)
			{
				Console.WriteLine(nro);
				cont++;
			}
			nro++;
		}
		
	}
}
