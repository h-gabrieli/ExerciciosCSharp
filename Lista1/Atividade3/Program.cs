namespace Atividade3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!"); double r;
            double a;

            Console.WriteLine("Digite o valor do raio:");
            r = double.Parse(Console.ReadLine());

            a = Math.PI * Math.Pow(r, 2.0);

            Console.WriteLine($"A={a.ToString("F4")}");
        }
    }
}
