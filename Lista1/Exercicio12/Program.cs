namespace Exercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int r = 3;
            double valorPI = 3.14159;
            double volume;

            volume = (4 / 3.0) * valorPI * Math.Pow(r, 3);

            Console.WriteLine($"VOLUME: {volume.ToString("F3")}");

           
        }
    }
}
