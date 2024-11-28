namespace MediaPonderada {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Nota da primeira prova: ");
            double nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Peso da primeira prova: ");
            double peso1 = double.Parse(Console.ReadLine());

            Console.WriteLine("nota da segunda prova: ");
            double nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Peso da segunda prova: ");
            double peso2 = double.Parse(Console.ReadLine());

            double mediaPonderada = (nota1 * peso1) + (nota2 * peso2);

            Console.WriteLine($"A média ponderada do aluno é {mediaPonderada:F2}.");


        }
    }
}
