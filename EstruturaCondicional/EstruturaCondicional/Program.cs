using System;

namespace EstruturaCondicional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Para rodar o exercício 1:
            // Exercicio1();

            // Para rodar o exercício 2:
            Exercicio2.Rodar();
        }

        static void Exercicio1()
        {
            Console.WriteLine("Entre com um número inteiro:");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
                Console.WriteLine("O número é par.");
            else
                Console.WriteLine("O número é ímpar.");
        }
    }
}
