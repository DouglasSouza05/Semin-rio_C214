// See https://aka.ms/new-console-template for more information

using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
using Core.Aplication;

class Program
{
    static void Main()
    {

        UnitsConverter unitsConverter = new UnitsConverter();

        Console.WriteLine("Conversão de Celsius para Fahrenheit");
        Console.WriteLine("Digite a temperatura em Celsius: ");
        
        if (double.TryParse(Console.ReadLine(), out double celsius))
        {
            double fahrenheit = unitsConverter.CelsiusToFahrenheit(celsius);
            Console.WriteLine($"Temperatura em Fahrenheit: {fahrenheit:F2} Graus");
        }
        else
        {
            Console.WriteLine("Entrada inválida. Certifique-se de digitar um número.");
        }
    }
}