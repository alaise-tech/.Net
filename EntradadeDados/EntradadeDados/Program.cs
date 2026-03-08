using System;

namespace EntradadeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase = Console.ReadLine(); // Lê uma linha de texto do console e armazena na variável 'frase'
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();

            Console.WriteLine("Você digitou: " + frase); // Exibe a frase digitada pelo usuário
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

            Console.WriteLine("=======================================================================================");

            // Parse de string para int
            int n1 = int.Parse(Console.ReadLine()); // Lê uma linha do console, converte para inteiro e armazena em 'n1'
            char ch = char.Parse(Console.ReadLine()); // Lê uma linha do console, converte para caractere e armazena em 'ch'

            Console.WriteLine("Número inteiro: " + n1); // Exibe o número inteiro digitado pelo usuário
            Console.WriteLine("Caractere: " + ch); // Exibe o caractere digitado pelo usuário



        }
    }
}