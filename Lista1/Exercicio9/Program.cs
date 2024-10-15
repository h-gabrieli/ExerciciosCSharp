namespace Exercicio9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numFuncionario;
            int quantHora;
            double valorHora;
            double salarioFuncionario;

            Console.Write("Número do funcionário:");
            numFuncionario = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Horas trabalhada:");
            quantHora = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Valor por hora trabalhada:");
            valorHora = double.Parse(Console.ReadLine());
            Console.WriteLine();
            salarioFuncionario = quantHora * valorHora;

            Console.WriteLine($"Número = {numFuncionario}");
            Console.WriteLine($" R$ = {salarioFuncionario.ToString("F2")}");

        }
    }
}
