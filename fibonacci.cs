using System;
					
public class Program
{
	public static void Main()
	{

		int a=1, b=0, N=10;
		
		for(int i=0; i<N; i++)
		{
			
			int temp = a;
			a = b;
			b = temp + a;
			Console.WriteLine(b);
		}

	}
}
