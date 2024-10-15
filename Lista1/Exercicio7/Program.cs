namespace Exercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double notaA = 2;
            double notaB = 3;
            double notaC = 5;

            double media;

            Console.WriteLine($"Nota A = {notaA}");
            Console.WriteLine($"Nota B = {notaB}");
            Console.WriteLine($"Nota C = {notaC}");

            media = (notaA + notaB + notaC) / 3;

            Console.WriteLine($"MEDIA = {media.ToString("F1")}");
        }
    }
}
