// See https://aka.ms/new-console-template for more information

Console.Write("Digite o número de maçãs compradas: ");
int quantidade = int.Parse(Console.ReadLine());

double precoUnitario = quantidade < 12 ? 1.30 : 1.00;
double total = quantidade * precoUnitario;

Console.WriteLine($"\nO custo total da compra é: R$ {total:F2}");
