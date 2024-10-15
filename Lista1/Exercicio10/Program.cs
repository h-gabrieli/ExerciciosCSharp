namespace Exercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nomeVendedor;
            double salarioFixo;
            double montanteVendas;
            double comissao;
            double total;
            double totalReceber;
            

            Console.Write("Nome:");
            nomeVendedor = Console.ReadLine();
            Console.Write("Salario fixo:");
            salarioFixo = double.Parse(Console.ReadLine());
            Console.Write("Total de vendas:");
            montanteVendas = double.Parse(Console.ReadLine());

            comissao = salarioFixo + montanteVendas;
            total = comissao * 0.15;
            totalReceber = total + salarioFixo;
            Console.Write($"Salário total R$ = {totalReceber.ToString("F2")}");
        }
    }
}
