namespace SequenciaFibonacci {
    internal class Program {
        static void Main(string[] args) {
            // Entrada
            Console.Write("Número máximo: ");
            int maxNumero = int.Parse(Console.ReadLine());

            // Sequência de Fibonacci
            int a = 0, b = 1;
            Console.Write("Sequência de Fibonacci até " + maxNumero + ": ");
            while (a <= maxNumero) {
                Console.Write(a + " ");
                int temp = a;
                a = b;
                b = temp + b;
            }
           // Console.WriteLine();

        }


    }
}

