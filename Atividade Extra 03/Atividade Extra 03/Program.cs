// See https://aka.ms/new-console-template for more information

Console.Write("Digite o valor de A: ");
double a = double.Parse(Console.ReadLine());

Console.Write("Digite o valor de B: ");
double b = double.Parse(Console.ReadLine());

Console.Write("Digite o valor de C: ");
double c = double.Parse(Console.ReadLine());

double delta = Math.Pow(b, 2) - 4 * a * c;

Console.WriteLine($"\nO valor de Delta é: {delta:F2}");
