namespace Exercicio18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tempo;
            int velocidade;
            double km;
            double litros;

            Console.Write("Tempo gasto:");
            tempo = int.Parse(Console.ReadLine());
            Console.Write("Velocidade média:");
            velocidade = int.Parse(Console.ReadLine());

            km = tempo * velocidade;
            Console.Write($"Distancia : {km} KM");

            litros = km / 12;

            Console.Write($" Litros : {litros.ToString("F3")}");

        }
    }
}
