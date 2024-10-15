namespace Exercicio16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1,y1;
            double x2,y2;
            double distancia;
            


            Console.WriteLine("Digite os valores de x1 e y1:");
            x1 = double.Parse(Console.ReadLine());
            y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite os valores de x2 e y2:");
            y2 = double.Parse(Console.ReadLine());
            x2 = double.Parse(Console.ReadLine());

            distancia = Math.Sqrt(Math.Pow((x2 - x1), 2.0) + Math.Pow((y2 - y1), 2.0)); ;
            Console.WriteLine($"Distancia: {distancia.ToString("F4")}");
        }
    }
}
