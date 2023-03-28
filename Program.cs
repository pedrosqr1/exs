using System;

namespace ex10
{
    public class Program
    {
        static void Main(string[] args)
        {
            int codigo;

            Console.WriteLine("Insira um código: ");
            codigo = Convert.ToInt32(Console.ReadLine());

            if (codigo == 1)
            {
                Console.WriteLine("Alimento não perecível");
            }
            if ((codigo == 2) || (codigo == 3) || (codigo == 4))
            {
                Console.WriteLine("Alimento perecível");
            }
            if ((codigo == 5) || (codigo == 6))
            {
                Console.WriteLine("Vestuário");
            }
            if ((codigo == 8) || (codigo == 9) || (codigo == 10) || (codigo == 11) || (codigo == 12) || (codigo == 13) || (codigo == 14) || (codigo == 15))
            {
                Console.WriteLine("Higiene Pessoal");
            }
            

        }
    }
}
