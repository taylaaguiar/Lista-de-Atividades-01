// See https://aka.ms/new-console-template for more information

Console.Write("Digite o salário atual do funcionário: R$ ");
double salarioAtual = double.Parse(Console.ReadLine());

Console.Write("Digite o percentual de reajuste (%): ");
double percentualReajuste = double.Parse(Console.ReadLine());

double novoSalario = salarioAtual + (salarioAtual * percentualReajuste / 100);

Console.WriteLine($"\nO novo salário do funcionário é: R$ {novoSalario:F2}");
