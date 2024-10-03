namespace Atividade2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int x;
            Console.WriteLine($"Digite um numero:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine($"Digite outro numero:");
            b = int.Parse(Console.ReadLine());

            x = (a + b);
            Console.WriteLine($"X = {x}");
        }
    }
}
