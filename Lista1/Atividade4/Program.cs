namespace Atividade4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int soma;

            Console.WriteLine("Digite um numero:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro numero:");
            b = int.Parse(Console.ReadLine());

            soma = (a + b);
            Console.WriteLine($"SOMA = {soma}");
        }
    }
}
