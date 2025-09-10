// See https://aka.ms/new-console-template for more information

using System;

        Console.Write("Digite o número total de eleitores: ");
        int totalEleitores = int.Parse(Console.ReadLine());

        Console.Write("Digite o número de votos brancos: ");
        int votosBrancos = int.Parse(Console.ReadLine());

        Console.Write("Digite o número de votos nulos: ");
        int votosNulos = int.Parse(Console.ReadLine());

        Console.Write("Digite o número de votos válidos: ");
        int votosValidos = int.Parse(Console.ReadLine());

        double percBrancos = (double)votosBrancos / totalEleitores * 100;
        double percNulos = (double)votosNulos / totalEleitores * 100;
        double percValidos = (double)votosValidos / totalEleitores * 100;

        Console.WriteLine($"\nPercentual de votos brancos: {percBrancos:F2}%");
        Console.WriteLine($"Percentual de votos nulos: {percNulos:F2}%");
        Console.WriteLine($"Percentual de votos válidos: {percValidos:F2}%");



