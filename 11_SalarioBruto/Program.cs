namespace _11_SalarioBruto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double INSS = 0.12;
            double[] salariosBrutos = new double[5];
            double[] salariosLiquidos = new double[5];


            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Digite o salário bruto da {i + 1}ª pessoa: ");
                salariosBrutos[i] = double.Parse(Console.ReadLine()!);
                salariosLiquidos[i] = salariosBrutos[i] * (1 - INSS);
            }

            for (int i =0; i < 5; i++)
            {

            }

            Console.WriteLine("\nSalários líquidos:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i + 1}ª Pessoa: R$ {salariosLiquidos[i]:F2}");
            }
        }
    }
}
