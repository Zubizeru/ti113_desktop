namespace StatusAluno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o nome do Aluno(a): ");
            string nome = Console.ReadLine()!;
            Console.Write("Informe a primeira Nota: ");
            double nota1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Informe a segunda Nota: ");
            double nota2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            double media = (nota1 + nota2) / 2;

            if (media >= 7)
            {   
                Console.WriteLine($"Aluno(a) {nome} está aprovado!");
            }            
            else if (media >= 5)
            {
                Console.WriteLine($"Aluno(a) {nome} está em recuperação");
            }            
            else
            {
                Console.WriteLine($"Aluno(a) {nome} está reprovado");
            }
        }
    }
}
