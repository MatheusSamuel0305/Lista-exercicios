namespace TerrenoRetangular {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Comprimento do terreno (em metros): ");
            double comprimento = double.Parse(Console.ReadLine());

            Console.WriteLine("Largura do terreno (em metros): ");
            double largura = double.Parse(Console.ReadLine());

            double area = comprimento * largura;

            Console.WriteLine($"A área do terreno é {area} metros quadrados.");

        }
    }
}
