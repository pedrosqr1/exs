using System;

namespace ex8
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int numero1;
            int numero2;
            string operacao;
            float soma;
            float subtracao;
            float multiplicacao;
            float quociente;

            Console.WriteLine("Digite o primeiro número: ");
            numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            numero2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Selecione a operação desejada: A= soma. S= subtração. M= multiplicação. Q= quociente. ");
            operacao = Console.ReadLine();



            soma = numero1 + numero2;
            subtracao = numero1 - numero2;
            multiplicacao = numero1 * numero2;
            quociente = numero1 / numero2;

            if (operacao == "A")
            {
                Console.WriteLine($"Soma: {soma}");
            }
            if (operacao == "S")
            {
                Console.WriteLine($"Subtração: {subtracao}");
            }
            if (operacao == "M")
            {
                Console.WriteLine($"Muliplicação: {multiplicacao}");
            }
            if (operacao == "Q")
            {
                Console.WriteLine($"Quociente: {quociente}");
            }
        }
    }
}