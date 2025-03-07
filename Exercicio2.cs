using System;

class Program
{
    static void Main()
    {
        Console.Write("Quantos números deseja inserir? ");
        int n = int.Parse(Console.ReadLine());

        int[] numeros = new int[n];
        int countPares = 0;

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Digite o número {i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Números pares:");
        foreach (int num in numeros)
        {
            if (num % 2 == 0)
            {
                Console.Write(num + " ");
                countPares++;
            }
        }

        Console.WriteLine($"\nQuantidade de números pares: {countPares}");
    }
}
