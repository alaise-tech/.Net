using System;

namespace Funcoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite três números:");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            double resultado = Maior(num1, num2, num3); // Chamada da função para encontrar o maior número entre os três digitados

            Console.WriteLine($"O maior número é: {resultado}");
        }

        static int Maior(int a, int b, int c) // Função que recebe três números inteiros e retorna o maior entre eles
        {
            int m; // Variável para armazenar o maior número  
            if (a > b && a > c)
            {
                m = a;
            }
            else if (b > a && b > c)
            {
                m = b;
            }
            else
            {
                m = c;
            }
            return m; // Retorna o maior número encontrado
        }
    }
}
