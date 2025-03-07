using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite a quantidade de alunos: ");
        int N = int.Parse(Console.ReadLine());

        string[] nomes = new string[N];
        double[] nota1 = new double[N];
        double[] nota2 = new double[N];

        for (int i = 0; i < N; i++)
        {
            Console.WriteLine($"Digite o nome do {i + 1}º aluno: ");
            nomes[i] = Console.ReadLine();

            Console.Write("Digite a nota do 1º semestre: ");
            nota1[i] = double.Parse(Console.ReadLine());

            Console.Write("Digite a nota do 2º semestre: ");
            nota2[i] = double.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nAlunos aprovados:");
        for (int i = 0; i < N; i++)
        {
            double media = (nota1[i] + nota2[i]) / 2.0;
            if (media >= 6.0)
            {
                Console.WriteLine(nomes[i]);
            }
        }
    }
}
