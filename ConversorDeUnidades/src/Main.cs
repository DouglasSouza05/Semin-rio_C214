// See https://aka.ms/new-console-template for more information

using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

class Program
{
    static void Main()
    {

        UnitsConverter converter = new UnitsConverter();

        Console.WriteLine("Conversão de Celsius para Fahrenheit");
        Console.WriteLine("Digite a temperatura em Celsius: ");
        
        if (double.TryParse(Console.ReadLine(), out double celsius))
        {
            double fahrenheit = converter.CelsiusToFahrenheit(celsius);
            Console.WriteLine($"Temperatura em Fahrenheit: {fahrenheit:F2} Graus");
        }
        else
        {
            Console.WriteLine("Entrada inválida. Certifique-se de digitar um número.");
        }
    }
}