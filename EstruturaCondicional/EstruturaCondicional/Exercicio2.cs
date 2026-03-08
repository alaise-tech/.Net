using System;

namespace EstruturaCondicional
{
    internal class Exercicio2
    {
        public static void Rodar()
        {
            Console.WriteLine("Qual o horário atual?");
            int hora = int.Parse(Console.ReadLine() ?? "0");

            if (hora < 12)
            {
                Console.WriteLine("Bom dia!");
            }
            else if (hora < 18)
            {
                Console.WriteLine("Boa tarde!");
            }
            else
            {
                Console.WriteLine("Boa noite!");
            }
        }
    }
}
