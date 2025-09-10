// See https://aka.ms/new-console-template for more information

double n1;
double n2;
Console.WriteLine("DIGITE A PRIMEIRA NOTA: ");
n1 = double.Parse(Console.ReadLine());
Console.WriteLine("DIGITE A PRIMEIRA NOTA: ");
n2 = double.Parse(Console.ReadLine());
Console.WriteLine($"A SOMA É IGUAL: {n1 + n2}");
if (6 < n1 + n2)
{
    Console.WriteLine("Parabéns!Você se esforçou, aprendeu e venceu. Que venha o próximo ano com ainda mais conquistas!");
}
else
{
    Console.WriteLine("Não desanime.Cada pessoa tem seu tempo. Aprender é um caminho, e você ainda tem muitas chances de vencer!");
}
