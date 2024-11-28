namespace SomaNumeros {
    internal class Program {
        static void Main(string[] args) {

            Console.Write("Valor de A: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Valor de B: ");
            int b = int.Parse(Console.ReadLine());

            // Operação
            int soma = a + b;

            // Saída
            Console.WriteLine($"A + B = {soma}.");
        }
    }
}
