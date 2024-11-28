namespace SalarioTotal {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Salário base: R$ ");
            double salarioBase =  double.Parse(Console.ReadLine());

            Console.WriteLine("Total de vendas: R$ ");
            double totalVendas = double.Parse(Console.ReadLine());

            //double comissao = 0.05;

            double salarioTotal = salarioBase + (totalVendas * 0.05);

            Console.WriteLine($"O salário total do vendedor é R$ {salarioTotal:F2}.");

        }
    }
}
