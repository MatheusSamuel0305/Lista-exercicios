namespace OrdenacaoDecrescente {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Primeiro valor: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Terceiro valor: ");
            int c = int.Parse(Console.ReadLine());

            int[] valores = { a, b, c };
            Array.Sort(valores);
            Array.Reverse(valores);

            Console.WriteLine($"Os números em ordem decrescente são {valores[0]}, {valores[1]}, {valores[2]}.");


        }
    }
}
