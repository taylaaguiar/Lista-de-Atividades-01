// See https://aka.ms/new-console-template for more information

int num;
Console.WriteLine("Escreva um número para saber seu antecedente!");
num = int.Parse(Console.ReadLine()!);
Console.WriteLine($"O antecessor é: {num - 1}");
