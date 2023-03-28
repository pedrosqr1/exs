using System;

public class Program
{
	public static void Main()
	{
		float numeroa;
		float numerob;
		float numeroc;

		Console.WriteLine("Insira o valor de A: ");
		numeroa = Convert.ToSingle(Console.ReadLine());

		Console.WriteLine("Insira o valor de B: ");
		numerob = Convert.ToSingle(Console.ReadLine());

		Console.WriteLine("Insira o valor de C: ");
		numeroc = Convert.ToSingle(Console.ReadLine());

		if (numeroc < numeroa + numerob)
		{
			Console.WriteLine("A soma de A+B é maior que C");
		}

		if (numeroc > numeroa + numerob)
		{
			Console.WriteLine("A soma de A+B é menor que C");
		}
		if (numeroc == numeroa + numerob)
		{
			Console.WriteLine("A soma de A+B é igual a C");
		}
	}

}