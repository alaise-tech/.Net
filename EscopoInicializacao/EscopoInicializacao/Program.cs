using System;

namespace EscopoInicializacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double preco = double.Parse(Console.ReadLine());
            double desconto = 0.0;

            if (preco < 20.0)
            {
                desconto = preco * 0.1;
            }
            else
            {
                desconto = preco * 0.05;
            }
            Console.WriteLine("O desconto é de:" + desconto);
        }
    }
}
