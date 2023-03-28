using System;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)

        //2. Escreva um algoritmo que lê três valores para os lados de um triângulo. O algoritmo deve verificar se o triângulo é equilátero(todos os lados iguais), isósceles(dois lados iguais) ou scaleno(todos lados diferentes).

        {

            float lado1;
            float lado2;
            float lado3;

            Console.WriteLine("Digite o valor do lado 1: ");
            lado1 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite o valor do lado 2: ");
            lado2 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite o valor do lado 3: ");
            lado3 = Convert.ToSingle(Console.ReadLine());

            if ((lado1 == lado2) && (lado1 == lado3))
            {
                Console.WriteLine("O triângulo é equilátero.");
            }
            if ((lado1 != lado2) && (lado2 != lado3) && (lado3 != lado1))
            {
                Console.WriteLine("O triangulho é scaleno.");
            }
            if ((lado1 == lado2) && (lado1 != lado3))
            {
                Console.WriteLine("O triângulo é isóceles.");
            }
            if ((lado2 == lado3) && (lado1 != lado2))
            {
                Console.WriteLine("O triângulo é isóceles.");
            }
            if ((lado1 == lado3) && (lado1 != lado2))
            {
                Console.WriteLine("O triângulo é isóceles.");
            }

        }
    }
}
