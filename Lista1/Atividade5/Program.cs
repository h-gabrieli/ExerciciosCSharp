namespace Atividade5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor;
            int valor2;
            int prod;

            Console.WriteLine("Digite o valor de produto 1:");
            valor = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do produto 2:");
            valor2 = int.Parse(Console.ReadLine());

            prod = (valor * valor2);
            Console.WriteLine($"PROD = {prod}");
        }
    }
}
