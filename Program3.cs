using System;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            string sexo;

            Console.WriteLine("Insira o seu Sexo, M para masculino, F para Feminino: ");
            sexo = (Console.ReadLine());
            while ((sexo!="M") && (sexo!="F"))
            {
                Console.WriteLine("Sexo inválido. Insira o seu Sexo, M para masculino, F para Feminino: ");
                sexo = (Console.ReadLine());
            }
            Console.WriteLine("Insira o seu Nome:");
            nome = (Console.ReadLine());
            

            if (sexo=="M")
            {
                Console.WriteLine($"Ilmo Sr. {nome}");
            }
            if (sexo=="F")
            {
                Console.WriteLine($"Ilmo Sra. {nome}");
            }
        }
    }
}
