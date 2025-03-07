using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite a quantidade de pessoas: ");
        int qtde = int.Parse(Console.ReadLine());

        string[] nomes = new string[qtde];
        int[] idades = new int[qtde];

        // Captura dos nomes e idades
        for (int i = 0; i < qtde; i++)
        {
            Console.Write("Digite o nome: ");
            nomes[i] = Console.ReadLine();

            Console.Write("Digite a idade: ");
            idades[i] = int.Parse(Console.ReadLine());
        }

        // Determinar a pessoa mais velha
        int idadeMaisVelha = idades[0];
        string maisVelha = nomes[0];

        for (int i = 1; i < qtde; i++)
        {
            if (idades[i] > idadeMaisVelha)
            {
                idadeMaisVelha = idades[i];
                maisVelha = nomes[i];
            }
        }

        Console.WriteLine($"\nA pessoa mais velha é: {maisVelha} com {idadeMaisVelha} anos.");
    }
}



