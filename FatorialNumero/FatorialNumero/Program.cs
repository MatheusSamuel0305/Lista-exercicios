namespace FatorialNumero {
    internal class Program {
        static void Main(string[] args) {

            Console.Write("Número: ");
            int numero = int.Parse(Console.ReadLine());

            int fatorial = 1;
            for (int i = 1; i <= numero; i++) { 
                fatorial *= i; 
            }

            Console.WriteLine($"{numero}! = {fatorial}.");


        }
    }
}
