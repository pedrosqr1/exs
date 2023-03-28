using System;

namespace ex9
{
    public class Program
    {
        static void Main(string[] args)
        {
            float horasAula1;
            float horasAula2;
            float salario1;
            float salario2;

            Console.WriteLine("Insira a quantidade de horas que o professor número 1 trabalhou: ");
            horasAula1 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Insira o valor da hora que o professor número 1 recebe: ");
            salario1 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Insira a quantidade de horas que o professor número 2 trabalhou: ");
            horasAula2 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Insira o valor da hora que o professor número 2 recebe: ");
            salario2 = Convert.ToSingle(Console.ReadLine());

            float soma1 = horasAula1 * salario1;
            float soma2 = horasAula2 * salario2;

            if (soma1 > soma2)
            {
                Console.WriteLine("O professor 1 ganhou mais que o professor 2");
            }
            if (soma1 < soma2)
            {
                Console.WriteLine("O professor 2 ganhou mais que o professor 1");
            }
            if (soma1 == soma2)
            {
                Console.WriteLine("Ambos receberam o mesmo salário");
            }

        }
    }
}
