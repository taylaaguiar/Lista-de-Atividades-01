// See https://aka.ms/new-console-template for more information

double n1;
double n2;
Console.WriteLine("DIGITE SEU PRIMEIRO VALOR: ");
n1 = double.Parse(Console.ReadLine());
Console.WriteLine("DIGITE SEU SEGUNDO VALOR: ");
n2 = double.Parse(Console.ReadLine());
if (n1 < n2)
{
    Console.WriteLine($"{n1} É MENOR QUE {n2}");
}
else
{
    Console.WriteLine($"{n2} É MENOR QUE {n1}");
}