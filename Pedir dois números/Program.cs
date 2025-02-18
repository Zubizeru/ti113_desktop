namespace Pedir_dois_números
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

            if (num1 > num2)
            {
                Console.WriteLine($"O primeiro número {num1} é maior que o segundo número {num2}");
            }
            else if (num2 > num1)
            {
                Console.WriteLine($"O segundo número {num2} é maior que o primeiro número {num1}");
            }
            else
            {
                Console.WriteLine("Os números inseridos são iguais!");
            }
        }
    }
}
