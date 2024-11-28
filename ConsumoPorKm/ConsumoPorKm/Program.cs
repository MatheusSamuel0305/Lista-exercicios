namespace ConsumoPorKm {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Quilometragem inicial: ");
            double quilometragemInicial = double.Parse(Console.ReadLine());

            Console.WriteLine("Quilometragem final: ");
            double quilometragemFinal = double.Parse(Console.ReadLine());

            Console.WriteLine("Consumo de combustível (em litros): ");
            double consumoCombustivel = double.Parse(Console.ReadLine());

            double consumoPorKm = consumoCombustivel / (quilometragemFinal - quilometragemInicial);

            Console.WriteLine($"O consumo de combustível por quilômetro é de {consumoPorKm:F2} litros/km.");

        }
    }
}
