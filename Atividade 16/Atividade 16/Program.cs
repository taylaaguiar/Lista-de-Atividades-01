// See https://aka.ms/new-console-template for more information

{
    Console.Write("Digite um número inteiro para calcular o fatorial: ");
    int n;
    bool sucesso = int.TryParse(Console.ReadLine(), out n);

    if (!sucesso)
    {
        Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro.");
    }
    else if (n < 0)
    {
        Console.WriteLine("Fatorial de número negativo não existe.");
    }
    else
    {
        long fatorial = 1;

        for (int i = 1; i <= n; i++)
        {
            fatorial *= i;
        }

        Console.WriteLine($"{n}! = {fatorial}");
    }

    Console.WriteLine("Pressione qualquer tecla para sair...");
    Console.ReadKey();
}
    