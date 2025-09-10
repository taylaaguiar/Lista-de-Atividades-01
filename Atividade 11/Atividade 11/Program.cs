// See https://aka.ms/new-console-template for more information

Console.Write("Digite o ano atual: ");
int anoAtual = int.Parse(Console.ReadLine());

Console.Write("Digite o ano de nascimento: ");
int anoNascimento = int.Parse(Console.ReadLine());

int idade = anoAtual - anoNascimento;

Console.WriteLine($"\nIdade calculada: {idade} anos");

if (idade < 16)
{
    Console.WriteLine("Você NÃO pode votar este ano.");
}
else if ((idade >= 16 && idade < 18) || idade >= 70)
{
    Console.WriteLine("Seu voto é FACULTATIVO.");
}
else
{
    Console.WriteLine("Você é OBRIGADO a votar este ano.");
}
