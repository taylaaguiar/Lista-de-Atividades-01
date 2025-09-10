// See https://aka.ms/new-console-template for more information

Console.Write("Digite um número: ");
int valor = int.Parse(Console.ReadLine());

if (valor > 10)
{
    Console.WriteLine("É MAIOR QUE 10!");
}
else
{
    Console.WriteLine("NÃO É MAIOR QUE 10");
}