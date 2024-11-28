namespace ConversaoFahrenheit_Celsius {
    internal class Program {
        static void Main(string[] args) {

            Console.Write("Temperatura em Fahrenheit: ");
            double fahrenheit = double.Parse(Console.ReadLine());

            double celsius = (fahrenheit - 32) * 5 / 9;

            Console.WriteLine($"A temperatura em Celsius é {celsius:F2} ºC.");

        }
    }
}
