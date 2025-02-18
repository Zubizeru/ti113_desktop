namespace Comparar_três_números__maior__menor_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Imprimir o maior número");
            Console.Write("Informe o primeiro número: ");
            double num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe o segundo número: ");
            double num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe o terceiro número: ");
            double num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
            {
                if (num2 == num3)
                {
                    Console.WriteLine($"O primeiro número ({num1}) é maior que o segundo e terceiro número, ambos sendo ({num2}).");
                }
                else if (num2 > num3)
                {
                    Console.WriteLine($"O primeiro número ({num1}) é o maior número, o segundo número ({num2}) é o segundo maior, o terceiro número ({num3}) é o menor de todos");
                }
                else
                {
                    Console.WriteLine($"O primeiro número ({num1}) é o maior número, o terceiro número ({num3}) é o segundo maior, o segundo número ({num2}) é o menor de todos");
                }
            }
            else if (num2 > num1 && num2 > num3)
            {
                if (num1 == num3)
                {
                    Console.WriteLine($"O segundo número ({num2}) é maior que o primeiro e terceiro número, ambos sendo ({num1}).");
                }
                else if (num1 > num3)
                {
                    Console.WriteLine($"O segundo número ({num2}) é o maior número, o primeiro número ({num1}) é o segundo maior, o terceiro número ({num3}) é o menor de todos");
                }
                else
                {
                    Console.WriteLine($"O segundo número ({num2}) é o maior número, o terceiro número ({num3}) é o segundo maior, o primeiro número ({num1}) é o menor de todos");
                }
            }
            else if (num3 > num1 && num3 > num2)
            {
                if (num1 == num2)
                {
                    Console.WriteLine($"O terceiro número ({num3}) é maior que o primeiro e segundo número, ambos sendo ({num1}).");
                }
                else if (num1 > num2)
                {
                    Console.WriteLine($"O terceiro número ({num3}) é o maior número, o primeiro número ({num1}) é o segundo maior, o segundo número ({num2}) é o menor de todos");
                }
                else
                {
                    Console.WriteLine($"O terceiro número ({num3}) é o maior número, o segundo número ({num2}) é o segundo maior, o primeiro número ({num1}) é o menor de todos");
                }
            }
            else
            {
                Console.WriteLine($"Os números inseridos são iguais ({num1}).");
            }
        }
    }
}
