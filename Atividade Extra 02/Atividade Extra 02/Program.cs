// See https://aka.ms/new-console-template for more information

        Console.Write("Digite a largura da parede (em metros): ");
        double largura = double.Parse(Console.ReadLine());

        Console.Write("Digite a altura da parede (em metros): ");
        double altura = double.Parse(Console.ReadLine());

        double area = largura * altura;
        double litrosTinta = area / 2;

        Console.WriteLine($"\nÁrea da parede: {area:F2} m²");
        Console.WriteLine($"Quantidade de tinta necessária: {litrosTinta:F2} litros");