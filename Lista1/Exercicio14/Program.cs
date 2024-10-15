namespace Exercicio14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int maiore;

            Console.WriteLine("Valor de A:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor de B:");
            b = int.Parse(Console.ReadLine());
            

            maiore = (a + b + Math.Abs (a-b))/2;

            Console.WriteLine($"MAIOR EH : {maiore}");
            
        }
    }
}
