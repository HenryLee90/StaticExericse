using System;

namespace StaticExersice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var temp1 = TempConverter.FahrenheitToCelsius(75.00);
            Console.WriteLine($"This tempurture in Fahrenheit {75.00} is this in Celcius {temp1}");
            var temp2 = TempConverter.CelsiusToFarenheit(21.81);
            Console.WriteLine($"This tempurture in Celcius {21.81} is this in Fehrenheit {temp2}");
     
        }

    }
}
