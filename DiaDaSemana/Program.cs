namespace DiaDaSemana
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Atividade Dia da Semana");
            Console.Write("Informe um número entre 1 e 7: ");
            Console.WriteLine("");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero <= 0 || numero > 7) {
                do {
                    Console.Clear();
                    Console.WriteLine("Por favor, insira um número entre 1 e 7; ");
                    numero = Convert.ToInt32(Console.ReadLine());
                } while (numero <= 0 || numero > 7);
            }
            switch (numero)
            {
                case 1: Console.WriteLine("Hoje é Domingo");
                    return;
                case 2: Console.WriteLine("Hoje é Segunda-Feira");
                    return;
                case 3: Console.WriteLine("Hoje é Terça-Feira");
                    return;
                case 4: Console.WriteLine("Hoje é Quarta-Feira");
                    return;
                case 5: Console.WriteLine("Hoje é Quinta-Feira");
                    return;
                case 6: Console.WriteLine("Hoje é Sexta-Feira");
                    return;
                case 7: Console.WriteLine("Hoje é Sábado");
                    return;
            }
        }
    }
}
