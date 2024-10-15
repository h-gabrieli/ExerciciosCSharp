namespace Exercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A;
            int B;
            int C;
            int D;

            int diferenca;

            Console.WriteLine($"Digite o valor de A:");
            A = int.Parse( Console.ReadLine() );
            Console.WriteLine($"Digite o valor de B:");
            B = int.Parse(Console.ReadLine());
            Console.WriteLine($"Digite o valor de C:");
            C = int.Parse(Console.ReadLine());
            Console.WriteLine($"Digite o valor de D:");
            D = int.Parse(Console.ReadLine());

            diferenca = (A * B) - (C * D);

            Console.WriteLine($"DIFERENCA = {diferenca}");
            
        }
    }
}
