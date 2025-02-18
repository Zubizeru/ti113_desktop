internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Informe seu Nome: ");
        string nome = Console.ReadLine()!;
        Console.WriteLine("");
        Console.Write("Informe a Nota 1: ");
        double nota1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("");
        Console.Write("Informe a Nota 2: ");
        double nota2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("");
        Console.Write("Informe a Nota 3: ");
        double nota3 = Convert.ToInt32(Console.ReadLine());

        double soma = nota1 + nota2 + nota3;
        double media = soma / 3;

        Console.WriteLine("");
        Console.WriteLine($"A media de {nome} é: {media}");
    }
}