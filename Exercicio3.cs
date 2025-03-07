using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o tamanho dos vetores: ");
        int N = int.Parse(Console.ReadLine());

        int[] A = new int[N];
        int[] B = new int[N];
        int[] C = new int[N];

        Console.WriteLine("Digite os elementos do vetor A:");
        for (int i = 0; i < N; i++)
        {
            A[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Digite os elementos do vetor B:");
        for (int i = 0; i < N; i++)
        {
            B[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < N; i++)
        {
            C[i] = A[i] + B[i];
        }

        Console.WriteLine("Vetor C (soma de A e B):");
        foreach (int num in C)
        {
            Console.Write(num + " ");
        }
    }
}

