namespace VolumeRetangulo {
    internal class Program {
        static void Main(string[] args) {

            Console.Write("Altura: ");
            int altura = int.Parse(Console.ReadLine());

            Console.Write("Largura: ");
            int largura = int.Parse(Console.ReadLine());

            Console.Write("Comprimento: ");
            int comprimento = int.Parse(Console.ReadLine());

            int volume = altura * largura * comprimento;

            Console.WriteLine($"O volume da caixa é {volume} unidades cúbicas");


        }
    }
}

//using System;

//class Program {
//    static void Main() {
//        // Entrada
//        Console.Write("Altura: ");
//        int altura = int.Parse(Console.ReadLine());

//        Console.Write("Largura: ");
//        int largura = int.Parse(Console.ReadLine());

//        Console.Write("Comprimento: ");
//        int comprimento = int.Parse(Console.ReadLine());

//        // Cálculo do volume
//        int volume = altura * largura * comprimento;

//        // Saída
//        Console.WriteLine($"O volume da caixa é {volume} unidades cúbicas.");
//    }
//}

