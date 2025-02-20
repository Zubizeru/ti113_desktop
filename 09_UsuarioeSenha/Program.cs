namespace _09_UsuarioeSenha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe seu nome de usuário: ");
            string nome = Console.ReadLine()!;

            Console.Write("Informe sua senha: ");
            string senha = Console.ReadLine()!;

            while (nome == senha)
            {
                Console.Clear();
                Console.Write("A senha não pode ser igual ao nome de usuario. Por favor, insira uma senha diferente: ");
                senha = Console.ReadLine()!;
            }

           /* Console.WriteLine($"\nNome: {nome}");
            Console.WriteLine($"Senha: {senha}"); */
        }
    }
}
