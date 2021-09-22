using System;
					
public class Program
{
	public static void Main()
	{
		int Numero = 10567;
		
		int cont=0;
		int temp = Numero;
		
		while(temp >0)
		{
			temp = temp / 10;
			cont++;
		}
		
		Console.WriteLine("{0} possui {1} digitos!", Numero, cont);
	}
}
