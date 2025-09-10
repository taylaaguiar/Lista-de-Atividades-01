// See https://aka.ms/new-console-template for more information

List<int> numeros = new List<int>();

Console.Write("Digite o primeiro número: ");
numeros.Add(int.Parse(Console.ReadLine()));

Console.Write("Digite o segundo número: ");
numeros.Add(int.Parse(Console.ReadLine()));

Console.Write("Digite o terceiro número: ");
numeros.Add(int.Parse(Console.ReadLine()));

numeros.Sort(); // Ordena em ordem crescente

Console.WriteLine("\nOs números em ordem crescente são:");
foreach (int numero in numeros)
{
    Console.WriteLine(numero);
}