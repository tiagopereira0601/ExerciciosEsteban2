using System;

class Program
{
    static void Main()
    {
        Console.Write("Quantos números deseja inserir? ");
        int n = int.Parse(Console.ReadLine());

        double[] numeros = new double[n];
        double maior = double.MinValue;
        int posicao = 0;

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Digite o número {i + 1}: ");
            numeros[i] = double.Parse(Console.ReadLine());

            if (numeros[i] > maior)
            {
                maior = numeros[i];
                posicao = i;
            }
        }

        Console.WriteLine($"Maior número: {maior}");
        Console.WriteLine($"Posição do maior número: {posicao}");
    }
}
