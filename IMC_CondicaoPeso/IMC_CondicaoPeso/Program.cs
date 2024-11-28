namespace IMC_CondicaoPeso {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Peso (em kg): ");
            double peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Altura (em metros): ");
            double altura = double.Parse(Console.ReadLine());

            double imc = peso / (altura * altura);

            string condicao;
            if (imc < 18.5) {
                condicao = "Abaixo do peso";
            }
            else if (imc < 24.9) {
                condicao = "Peso normal";
            }
            else if (imc < 29.9) {
                condicao = "Sobrepeso";
            }
            else {
                condicao = "Obesidade";
            }

            Console.WriteLine($"IMC = {imc:F2} ({condicao}).");

        }
    }
}
