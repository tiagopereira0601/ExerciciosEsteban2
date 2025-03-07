{
    double media = 0;
    int qtde = 4;
    double[] numeros = new double[qtde];

    for (int i = 0; i < qtde; i++)
    {
        Console.Write("Digite um número:");
        numeros[i] = double.Parse(Console.ReadLine());

        for (int j = 0; j < qtde; j++)
        {
            media += numeros[j];
        }
    }
    double media1;
    media1 = media / qtde;
    Console.WriteLine("A média aritmética é: " + media);
    {
        for (int i = 0; i < qtde; i++)
        {
            media1 += numeros[i];
            Console.WriteLine("Os números abaixo da média são: " + numeros[i]);
        }
    }
}
Console.ReadKey();


