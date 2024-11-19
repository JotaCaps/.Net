using System.Globalization;

// See https://aka.ms/new-console-template for more information
Multiplicacao();

static void Soma()
{
    Console.Clear();
    Console.WriteLine("Primeiro valor: ");
    double v1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    Console.WriteLine("Segundo valor: ");
    double v2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    double resultado = v1 + v2;
    Console.WriteLine("");
    Console.WriteLine("O resultado da soma é: " + resultado);
    Console.ReadKey();
}

static void Subtracao()
{
    Console.Clear();
    Console.WriteLine("Primeiro valor: ");
    double v1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    Console.WriteLine("Segundo valor: ");
    double v2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    Console.WriteLine("");
    
    double resultado = v1 - v2; 
    Console.WriteLine("O resultado da subtração é " + resultado);
    Console.ReadKey();
}

static void Divisao()
{
    Console.Clear();
    Console.WriteLine("Primeiro valor: ");
    double v1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    Console.WriteLine("Segundo valor: ");
    double v2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    Console.WriteLine("");
    
    double resultado = v1 / v2; 
    Console.WriteLine("O resultado da divisão é " + resultado);
    Console.ReadKey();
}

static void Multiplicacao()
{
    Console.Clear();
    Console.WriteLine("Primeiro valor: ");
    double v1 = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);

    Console.WriteLine("Segundo valor: ");
    double v2 = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);

    Console.WriteLine("");
    
    double resultado = v1 * v2; 
    Console.WriteLine("O resultado da multiplicação é " + resultado);
    Console.ReadKey();
}
