namespace SomaMaior_Menor {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Valor de A: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Valor de B: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Valor de C: ");
            int c = int.Parse(Console.ReadLine());

            if ((a + b) < c) {
                Console.WriteLine("A + B é menor que C.");
            } else { 
                Console.WriteLine("A + B não é menor que C.");
            }

        }
    }
}
