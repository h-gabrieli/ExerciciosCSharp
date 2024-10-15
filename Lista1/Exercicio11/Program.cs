

namespace Exercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int codPeca1, numPecas1,codPeca2,numPecas2;
            double valorUnitario1,valorUnitario2,valorTotal;

            Console.WriteLine("Digite o codigo da peça 1:");
            codPeca1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o numero de peças 1:");
            numPecas1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor R$:");
            valorUnitario1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o codigo da peça 2:");
            codPeca2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o numero de peças 2:");
            numPecas2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor R$:");
            valorUnitario2 = double.Parse(Console.ReadLine());

            valorTotal = (numPecas1 * valorUnitario1) + (numPecas2 * valorUnitario2);

            Console.WriteLine($" R$ : {valorTotal.ToString("F2")}");
        }
    }
}
