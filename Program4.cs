using System;
//Tendo como dados de entrada a altura e o sexo de uma pessoa, construa um algoritmo 
//em que calcule peso ideal, utilizando as seguintes fórmulas:
//• Para homens: (72.7* h) –58
//• Para mulheres: (62.1* h) -44.7
//• Onde h equivale à altura da pessoa.
namespace ex4
{
    public class Program
    {
        static void Main(string[] args)
        {
            float altura;
            string sexo;

            Console.WriteLine("Digite a sua altura (em metros): ");
            altura = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite o seu sexo, M para Masculino, F para feminino: ");
            sexo = (Console.ReadLine());

            while ((sexo!="F") && (sexo!="M"))
            {
                Console.WriteLine("Sexo Inválido. Digite o seu sexo, M para Masculino, F para feminino: ");
                sexo = (Console.ReadLine());
            }
            double ideal;
            if (sexo == "M")
            {
                ideal = (72.7 * altura) - 58;
                    Console.WriteLine($"O seu peso ideal é de: {ideal}kg .");
            }
            if (sexo=="F")
            {
                ideal = (62.1 * altura) - 44.7;
                Console.WriteLine($"O seu peso ideal é de: {ideal}kg.");
            }
        }
    }
}
