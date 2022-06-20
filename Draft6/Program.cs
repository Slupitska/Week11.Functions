using System;

namespace Draft6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter temperature in Celsius : ");
            double celsius = Convert.ToDouble(Console.ReadLine());
            double fahrenheit();
            Console.WriteLine("The converted fahrenheit temperature is : " + fahrenheit);
            Console.ReadLine();
        }

        {
            fahrenheit = ((celsius* 9) / 5) + 32;    
            return fahrenheit;
        }

        {
            Console.Write("Enter temperature in Celsius : ");
            double celsius = Convert.ToDouble(Console.ReadLine());
            double fahrenheit = CelsiusFahrenheit(celsius);
            Console.WriteLine("The converted fahrenheit temperature is : " + fahrenheit);
            Console.ReadLine();
        }
        private static double CelsiusFahrenheit(double celsius)

        {
            return ((celsius * 9) / 5) + 32;
        }
        {
            Console.WriteLine("Enter Fahrenheit Temperature:");
            double Fahrenheit = Convert.ToDouble(Console.ReadLine()); ;
            double Celsius = FahrenheitCelsius(Fahrenheit);
            Console.WriteLine("The converted Celsius temperature is:" + Celsius);
            Console.ReadLine();
        }
        
        private static double FahrenheitCelsius(double Fahrenheit)
        {
                return (Fahrenheit - 32) * 5 / 9;
            
        }
    }
}
