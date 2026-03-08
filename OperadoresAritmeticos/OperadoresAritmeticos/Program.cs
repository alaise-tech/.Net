
namespace OperadoresAritmeticos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = 3 + 4 * 2;
            int n2 = (3 + 4) * 2;
            int n3 = 17 % 3;
            double n4 = (double) 10/ 8;  //Casting para obter um resultado decimal

            // Calculo com Baskara
            double a = 1.0;
            double b = -3.0;
            double c = -4.0;

            double delta = Math.Pow(b, 2.0) - 4 * a * c; // Calculando o valor de delta
            double x1 = (-b + Math.Sqrt(delta)) / (2 * a); // Calculando a primeira raiz

            Console.WriteLine("n1: " + n1);
            Console.WriteLine("n2: " + n2);
            Console.WriteLine("n3: " + n3);
            Console.WriteLine("n4: " + n4);
            Console.WriteLine("Delta: " + delta);
        }
    }
}