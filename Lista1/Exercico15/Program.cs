namespace Exercico15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int X;
            double Y;
            double kml;

            Console.WriteLine("Distância total percorrida KM:");
            X = int.Parse(Console.ReadLine());
            Console.WriteLine("Total de combustível gasto(Litros):");
            Y = double.Parse(Console.ReadLine());

            kml = X / Y;

            Console.WriteLine($"Km/l : {kml.ToString("F3")}");
        }
    }
}
