using System;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            float numero;
            Console.WriteLine("Insira um valor que esteja entre a faixa de 1 a 9: ");
            numero = Convert.ToSingle(Console.ReadLine());

            if ((numero < 1) || (numero > 9))
            {
                Console.WriteLine("O valor está fora da faixa permitida.");

            }
            else
            {
                Console.WriteLine("O valor está na faixa permitida.");
            }

        }
    }
}
