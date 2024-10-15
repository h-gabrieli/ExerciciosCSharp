

namespace Exercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double notaA = 3.5;
            double notaB = 7.5;


            Console.WriteLine($"Nota A : {notaA}");
           
            Console.WriteLine($"Nota B : {notaB}");
            

            double media = (notaA + notaB) / 2;

            Console.WriteLine($"MEDIA = {media.ToString("F4")}");
        }
    }
}
