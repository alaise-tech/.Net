using System;

namespace For
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine("Quantos números inteiros voce irá digitar:");
            int N = int.Parse(Console.ReadLine());

            int soma = 0;
            for (int i = 0; i < N; i++) // i++ é o mesmo que i = i + 1
            {
                Console.WriteLine("Digite um número inteiro:");
                int numero = int.Parse(Console.ReadLine());
                soma += numero; // soma = soma + numero
                
            }
            Console.WriteLine("Soma dos números digitados: " + soma);
        }
    }
}
