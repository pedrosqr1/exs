using System;

public class Program
{
    public static void Main(string[] args)
    {
        float ano;
        float idade;

        Console.WriteLine("Insira o ano do seu nascimento: ");
        ano = Convert.ToSingle(Console.ReadLine());
        idade = (2023 - ano);

        if (idade >= 18)
        {
            Console.WriteLine("Você pode votar e tirar Carteira de Habilitação. ");
        }
        if ((idade>=16) && (idade<18))
        {
            Console.WriteLine("Você pode votar, porém nao pode tirar Carteira de Habilitação. ");
        }
        if (idade < 16)
        {
            Console.WriteLine("Você não pode votar, nem tirar Carteira de Habilitação.");
        }
    }
}