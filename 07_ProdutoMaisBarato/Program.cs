namespace _07_ProdutoMaisBarato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] produtos = new string[6];
            double[] precos = new double[6];

            for (int i = 0; i < 6; i++)
            {
                Console.Write($"Informe o nome do {i + 1}º produto: ");
                produtos[i] = Console.ReadLine()!;

                Console.Write($"Informe o preço do {i + 1}º produto: ");
                precos[i] = Convert.ToDouble(Console.ReadLine());
            }

            double precoMaisBarato = precos.Min();
            int posicaoMaisBarato = Array.IndexOf(precos, precoMaisBarato);
            string produtoMaisBarato = produtos[posicaoMaisBarato];


            Console.WriteLine("\nO produto mais barato é:");
            Console.WriteLine($"Nome: {produtoMaisBarato}");
            Console.WriteLine($"Preço: R$ {precoMaisBarato:F2}");
        }
    }
}
