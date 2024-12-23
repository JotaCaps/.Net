﻿using System.Collections;
using System.Diagnostics;
using System.Globalization;

Menu();

static void Menu()
{
    Console.Clear();
    Console.WriteLine("O que deseja fazer? ");
    Console.WriteLine("1 - Soma");
    Console.WriteLine("2 - Subtração");
    Console.WriteLine("3 - Multiplicação");
    Console.WriteLine("4 - Divisão");
    Console.WriteLine("5 - Sair");
    
    Console.WriteLine("---------------");
    Console.Write("Selecione uma opção: ");
    short res = short.Parse(Console.ReadLine());

    switch(res)
    {
        case 1: Soma(); break;
        case 2: Subtracao(); break;
        case 3: Multiplicacao(); break;
        case 4: Divisao(); break;
        case 5: return;   
        default: Menu(); break;
    }
    
    
}

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
    Menu();
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
    Menu();
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
    Menu();
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
    Menu();
}
