using System;
using System.Globalization;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // Lê um número do usuário e converte para double usando a cultura invariante para garantir o formato correto

            while (x >= 0.0)
            {
                double raiz = Math.Sqrt(x); // Calcula a raiz quadrada de x usando a função Math.Sqrt
                Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture)); // Exibe a raiz quadrada formatada com 3 casas decimais usando a cultura invariante

                Console.WriteLine("Digite outro número: ");
                x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // CultureInfo.InvariantCulture é usado novamente para garantir que o número seja lido corretamente, independentemente da configuração regional do sistema.
            }
            Console.WriteLine("Número negativo!");
        }
    }
}
