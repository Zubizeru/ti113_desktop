namespace _10_Tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;

            while (continuar)
            {
                Console.Write("Digite um número para fazer a tabuada até 10: ");
                int numero = Convert.ToInt32(Console.ReadLine());

                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"{numero} x {i} = {numero * i}");
                }

                Console.WriteLine("\nDeseja fazer a tabuada novamente? Digite S para Sim ou qualquer outra tecla para Não.");
                string opcao = Console.ReadLine()!;
                opcao = opcao.ToLower();

                if ( opcao != "s" )
                {
                    continuar = false;
                }
                Console.Clear();
            }

        }
    }
}
