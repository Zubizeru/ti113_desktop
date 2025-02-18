namespace Comparar_três_números
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Imprimir o maior número");

            Console.Write("Informe o primeiro número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe o segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe o terceiro número: ");
            double num3 = Convert.ToDouble(Console.ReadLine());

            if (num1 == num2 && num2 == num3)
            {
                Console.WriteLine($"Os números inseridos são iguais ({num1}).");
            }
            else
            {
                double maior = Math.Max(num1, Math.Max(num2, num3));

                if ((num1 == maior && num2 == maior) || (num1 == maior && num3 == maior) || (num2 == maior && num3 == maior))
                {
                    Console.WriteLine($"Os dois maiores números são iguais ({maior}).");
                }
                else
                {
                    Console.WriteLine($"O maior número é {maior}.");
                }

            }
        }
    }
}

