namespace ParOuImpar {
    internal class Program {
        static void Main(string[] args) {

            Console.Write("Número: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0) {
                Console.WriteLine("O número é par.");
            }
            else {
                Console.WriteLine("O número é ímpar.");
            }

        }
    }
}
