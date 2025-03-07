using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite a quantidade de pessoas: ");
        int N = int.Parse(Console.ReadLine());

        double[] alturas = new double[N];
        char[] sexos = new char[N];

        double maiorAltura = double.MinValue;
        double menorAltura = double.MaxValue;
        double somaAlturaMulheres = 0;
        int quantidadeMulheres = 0;
        int quantidadeHomens = 0;

        for (int i = 0; i < N; i++)
        {
            Console.Write($"Digite a altura da {i + 1}ª pessoa (em metros): ");
            while (!double.TryParse(Console.ReadLine(), out alturas[i]) || alturas[i] <= 0)
            {
                Console.Write("Valor inválido. Digite novamente a altura: ");
            }

            Console.Write("Digite o sexo (M/F): ");
            sexos[i] = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            while (sexos[i] != 'M' && sexos[i] != 'F')
            {
                Console.Write("Entrada inválida. Digite o sexo (M/F): ");
                sexos[i] = char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine();
            }

            // Verifica maior e menor altura
            if (alturas[i] > maiorAltura)
                maiorAltura = alturas[i];

            if (alturas[i] < menorAltura)
                menorAltura = alturas[i];

            // Contabiliza homens e calcula média de altura das mulheres
            if (sexos[i] == 'M')
            {
                quantidadeHomens++;
            }
            else if (sexos[i] == 'F')
            {
                somaAlturaMulheres += alturas[i];
                quantidadeMulheres++;
            }
        }

        double mediaAlturaMulheres = quantidadeMulheres > 0 ? somaAlturaMulheres / quantidadeMulheres : 0;

        Console.WriteLine("\nResultados:");
        Console.WriteLine($"Maior altura do grupo: {maiorAltura:F2} m");
        Console.WriteLine($"Menor altura do grupo: {menorAltura:F2} m");
        Console.WriteLine($"Média de altura das mulheres: {(quantidadeMulheres > 0 ? mediaAlturaMulheres.ToString("F2") : "Nenhuma mulher cadastrada")}");
        Console.WriteLine($"Número de homens: {quantidadeHomens}");
    }
}
