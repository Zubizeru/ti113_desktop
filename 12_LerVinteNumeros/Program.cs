namespace _12_LerVinteNumeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> impares = new List<double>();
            List<double> pares = new List<double>();
            double[] numeros = new double[20];
            string mensagem = "Números informados:\n";

            for (int i = 0; i < 20; i++)
            {
                Console.Write($"Informe o {i + 1}º número: ");
                numeros[i] = Convert.ToDouble(Console.ReadLine());
            }

            for (int i = 0; i < numeros.Length; i++)
            {
                mensagem += numeros[i];

                if (i < numeros.Length - 1)
                {
                    mensagem += ", ";
                }
                else
                {
                    mensagem += ".";
                }

                if (numeros[i] % 2 == 0)
                {
                    pares.Add(numeros[i]);
                }
                else
                {
                    impares.Add(numeros[i]);
                }
            }

            mensagem += "\n\nNúmeros pares:\n";
            for (int i = 0; i < pares.Count; i++)
            {
                mensagem += pares[i];

                if (i < pares.Count - 1)
                {
                    mensagem += ", ";
                }
                else
                {
                    mensagem += ".";
                }
            }

            mensagem += "\n\nNúmeros ímpares:\n";
            for (int i = 0; i < impares.Count; i++)
            {
                mensagem += impares[i];

                if (i < impares.Count - 1)
                {
                    mensagem += ", ";
                }
                else
                {
                    mensagem += ".";
                }
            }
            Console.Clear();
            Console.WriteLine(mensagem);
        }
    }
}
