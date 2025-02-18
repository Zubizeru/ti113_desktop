namespace Comparar_três_números__maior__menor_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Imprimir o maior número");

            Console.Write("Informe o primeiro número: ");
            double num1 = double.Parse(Console.ReadLine()!);

            Console.Write("Informe o segundo número: ");
            double num2 = double.Parse(Console.ReadLine()!);

            Console.Write("Informe o terceiro número: ");
            double num3 = double.Parse(Console.ReadLine()!);
            Console.Clear();

            if (num1 == num2 && num2 == num3)
            {
                Console.WriteLine($"Os três números são iguais ({num1}).");
            }
            else
            {
                double maior = Math.Max(num1, Math.Max(num2, num3));
                double menor = Math.Min(num1, Math.Min(num2, num3));
                double meio = (num1 + num2 + num3) - (maior + menor);

                if (maior == meio)
                    Console.WriteLine($"Os dois maiores números são iguais ({maior}).\nO menor número é {menor}.");
                else
                    Console.WriteLine($"O maior número é {maior}.\nO número intermediário é {meio}.\nO menor número é {menor}.");
            }
        }
    }
}

