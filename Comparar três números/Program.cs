namespace Comparar_três_números
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
                } else {
                    Console.WriteLine($"O primeiro número ({num1}) é maior que o segundo número ({num2}) e o terceiro número ({num3}).");
                }            
            }
            else if (num2 > num1 && num2 > num3)
            {
                if (num1 == num3)
                {
                    Console.WriteLine($"O segundo número ({num2}) é maior que o primeiro e terceiro número, ambos sendo ({num1}).");
                }
                else {
                    Console.WriteLine($"O segundo número ({num2}) é maior que o primeiro número ({num1}) e o terceiro número ({num3}).");
                }
            }
            else if (num3 > num1 && num3 > num2)
            {
                if (num1 == num2)
                {
                    Console.WriteLine($"O terceiro número ({num3}) é maior que o primeiro e segundo número, ambos sendo ({num1}).");
                }
                else { 
                Console.WriteLine($"O terceiro número ({num3}) é maior que o primeiro número ({num1}) e o segundo número ({num2}).");
                }
            }
            else
            {
                Console.WriteLine($"Os números inseridos são iguais ({num1}).");
            }
            
        }
    }
}
