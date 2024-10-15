using System.Collections.Specialized;

namespace Exercicio13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A, B, C;
            double a1, b2, c3, d4, e5;
            double pi = 3.14159;

            Console.WriteLine("Digite o valor de A");
            A = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de B");
            B = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de C");
            C = double.Parse(Console.ReadLine());

            a1 = A * C / 2;

            Console.WriteLine($"a) a área do triângulo retângulo que tem A por base e C por altura : {a1} ");

            b2 = C * C * pi;

            Console.WriteLine($"b) a área do círculo de raio C. (pi = 3.14159) : {b2.ToString("F3")}");

            c3 =((A + B) * C) / 2;

            Console.WriteLine($"c) a área do trapézio que tem A e B por bases e C por altura: {c3}");

            d4 = B * B;

            Console.WriteLine($"d)a área do quadrado que tem lado B: {d4}");

            e5 = A * B;

            Console.WriteLine($"e) área do retângulo que tem lados A e B: {e5}");


        }
    }
}
