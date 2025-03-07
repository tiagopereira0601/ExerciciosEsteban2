using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite a quantidade de mercadorias: ");
        int N = int.Parse(Console.ReadLine());

        string[] nomes = new string[N];
        double[] precoCompra = new double[N];
        double[] precoVenda = new double[N];

        int lucroMenor10 = 0, lucroEntre10e20 = 0, lucroMaior20 = 0;
        double totalCompra = 0, totalVenda = 0, lucroTotal = 0;

        for (int i = 0; i < N; i++)
        {
            Console.Write($"Digite o nome da {i + 1}ª mercadoria: ");
            nomes[i] = Console.ReadLine();

            Console.Write("Digite o preço de compra: ");
            precoCompra[i] = double.Parse(Console.ReadLine());

            Console.Write("Digite o preço de venda: ");
            precoVenda[i] = double.Parse(Console.ReadLine());

            double lucro = ((precoVenda[i] - precoCompra[i]) / precoCompra[i]) * 100;
            totalCompra += precoCompra[i];
            totalVenda += precoVenda[i];
            lucroTotal += (precoVenda[i] - precoCompra[i]);

            if (lucro < 10)
                lucroMenor10++;
            else if (lucro <= 20)
                lucroEntre10e20++;
            else
                lucroMaior20++;
        }

        Console.WriteLine("\nRelatório de Lucros:");
        Console.WriteLine($"Mercadorias com lucro < 10%: {lucroMenor10}");
        Console.WriteLine($"Mercadorias com lucro entre 10% e 20%: {lucroEntre10e20}");
        Console.WriteLine($"Mercadorias com lucro > 20%: {lucroMaior20}");
        Console.WriteLine($"Total de compra: R$ {totalCompra:F2}");
        Console.WriteLine($"Total de venda: R$ {totalVenda:F2}");
        Console.WriteLine($"Lucro total: R$ {lucroTotal:F2}");
    }
}
