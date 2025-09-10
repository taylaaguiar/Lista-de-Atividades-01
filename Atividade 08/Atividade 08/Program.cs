// See https://aka.ms/new-console-template for more information


    Console.Write("Digite um número (diferente de zero): ");
    int valor = int.Parse(Console.ReadLine());

    if (valor == 0)
    {
        Console.WriteLine("Valor inválido! O número não pode ser zero.");
    }
    else if (valor > 0)
    {
        Console.WriteLine("O número é POSITIVO.");
    }
    else
    {
        Console.WriteLine("O número é NEGATIVO.");
    }
