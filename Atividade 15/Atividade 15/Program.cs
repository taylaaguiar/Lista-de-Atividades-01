// See https://aka.ms/new-console-template for more information

{
    Console.WriteLine("Números entre 1000 e 2000 com resto 5 ao dividir por 11:");
    Console.WriteLine("--------------------------------------------------------");

    for (int i = 1000; i <= 2000; i++)
    {
        if (i % 11 == 5)
        {
            Console.WriteLine(i);
        }
    }

    Console.WriteLine("--------------------------------------------------------");
    Console.WriteLine("Fim da verificação.");
    Console.ReadKey();
}
