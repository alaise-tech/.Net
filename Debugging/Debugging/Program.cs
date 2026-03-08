using System;

namespace Debugging
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite trêS núneros:");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine()); //Breakpoint aqui para verificar os valores de n1, n2 e n3

            double resultado = Maior(n1, n2, n3);

            Console.WriteLine("O maior número é: " + resultado);
        }
        static double Maior(int a, int b, int c)
        {
            double maior = a;
            if (b > maior)
            {
                maior = b;
            }
            if (c > maior)
            {
                maior = c;
            }
            return maior;

        }
    }
}
