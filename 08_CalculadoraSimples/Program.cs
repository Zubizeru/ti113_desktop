namespace _08_CalculadoraSimples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(@"
============================
    Soma - 1
    Subtração - 2
    Multiplicação - 3
    Divisão - 4
    Potenciação - 5
    Radiciação - 6
============================
Escolha o Cálculo: ");

            int menu = Convert.ToInt32(Console.ReadLine())!;
            while (menu < 1 || menu > 6)
            {
                Console.Clear();
                Console.Write(@"
============================
    Soma - 1
    Subtração - 2
    Multiplicação - 3
    Divisão - 4
    Potenciação - 5
    Radiciação - 6
============================
    Por favor, escolha um número entre 1 e 6 para o Cálculo: ");

                menu = Convert.ToInt32(Console.ReadLine())!;
            }
            Console.Clear();
            Console.Write("Informe o primeiro número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe o segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            while (menu == 4 && num2 == 0)
            {
                Console.Write("Erro: Divisão por zero não é permitida. Por favor, informe um número válido: ");
                num2 = Convert.ToDouble(Console.ReadLine());
            }

            while (menu == 6 && num2 == 0)
            {
                Console.Write("Erro: Raiz de índice zero não é permitida. Por favor, informe um número válido: ");
            }
            double resultado = 0;

            switch (menu)
            {
                case 1:
                    resultado = num1 + num2;
                    break;
                case 2:
                    resultado = num1 - num2;
                    break;
                case 3:
                    resultado = num1 * num2;
                    break;
                case 4:
                    resultado = num1 / num2;
                    break;
                case 5:
                    resultado = Math.Pow(num1, num2);
                    break;
                case 6:
                    resultado = Math.Pow(num1, 1 / num2);
                    break;
            }
            Console.WriteLine($"Resultado: {resultado}");
        }
    }
}
