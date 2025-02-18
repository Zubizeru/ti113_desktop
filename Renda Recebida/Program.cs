namespace Renda_Recebida
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Total de renda recebida por mês");
            Console.Write("Informe seu nome: ");
            string nome = Console.ReadLine()!;
            Console.WriteLine(" ");
            Console.Write("Informe o quanto ganha por hora: ");
            double salario = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" ");
            Console.Write("Informe o número de horas trabalhadas por mês: ");
            double horas = Convert.ToDouble(Console.ReadLine());

            Console.Clear();
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Sálario: R${salario}");
            Console.WriteLine($"Horas trabalhadas: {horas}");
            Console.WriteLine($"Total de renda recebida por mês: R${salario * horas}");
        }
    }
}
