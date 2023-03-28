using System;

namespace ex6
{
    public class Program
    {
        static void Main(string[] args)
        {
            string tipo;
            float valor;
            double total;
            Console.WriteLine("Insira o valor do produto: ");
            valor = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite o tipo de pagamento: ");
            tipo = (Console.ReadLine());
            
            if (tipo=="A")
            {
                total = valor * 0.9;
                Console.WriteLine($"Você recebeu 10% de desconto. Valor Total: R${total} .");
            }
            if (tipo=="B")
            {
                total = valor * 0.85;
                Console.WriteLine($"Você recebeu 15% de desconto. Valor Total: R${total} .");
            }
            if (tipo=="C")
            {
                total = valor;
                Console.WriteLine($"Preço normal de etiqueta. Valor Total: R${total} .");

            }
            if (tipo == "D")
            {
                total = valor*1.1;
                Console.WriteLine($"Preço de etiqueta com 10% de juros. Valor Total: R${total} .");

            }

        }
    }
}
