// See https://aka.ms/new-console-template for more information

Console.Write("Digite quanto dinheiro você tem na carteira (em R$): ");
double reais = double.Parse(Console.ReadLine());

double taxaDolar = 3.45;
double dolares = reais / taxaDolar;

Console.WriteLine($"\nCom R$ {reais:F2}, você pode comprar aproximadamente US$ {dolares:F2}");

