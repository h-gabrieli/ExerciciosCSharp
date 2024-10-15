namespace Exercicio17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 30;
            int y = 60;
            int d;
            int minutos;

            Console.Write($"Digite a distancia:");
            d = int.Parse( Console.ReadLine() );

            minutos = (60 * d) / 30;

            Console.WriteLine($"Minutos : {minutos}");

            
        }
    }
}
