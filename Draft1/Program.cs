using System;

namespace Draft1
{
    class Program
    {
        static void Main(string[] args)
      
        {
            //Из Цельсия в Фаренгейт: °C = (°F − 32) x 5 / 9
            //Из Фаренгейта в Цельсии:  °F = (°C × 9 / 5) +32

          
            Console.WriteLine("Сonvert Celsium Temperature to Fahrenheit (enter 1) or vice versa (enter 2)?:");
            char operation = Convert.ToChar(Console.ReadLine());

            if (char == 1)
            {
                Console.WriteLine("Enter the temperature in Celsium degrees:");
                double Celcius = Convert.ToDouble(Console.ReadLine()); ;
                double Fahrenheit = FahrenheitCelsius(Celsius);
                Console.WriteLine("The converted Fahrenheit temperature is:" + Fahrenheit);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Enter the temperature in Fahrenheit:");
                double Fahrenheit = Convert.ToDouble(Console.ReadLine());
                double Celsius = FahrenheitCelsius(Fahrenheit);
                Console.WriteLine("The converted Celsius temperature is:" + Celsius);
                Console.ReadLine();
                return (Fahrenheit - 32) * 5 / 9;
            }


            {
                Console.WriteLine("Enter Celsium Temperature:");
                double Celcius = Convert.ToDouble(Console.ReadLine()); ;
               
            }
            private static double FahrenheitCelsius(double Celsius)
            {
                return (Celsius × 9 / 5 )+ 32;
                
            }


            {
                Console.WriteLine("Enter Fahrenheit Temperature:");
                double Fahrenheit = Convert.ToDouble(Console.ReadLine()); ;
                
            }
            private static double FahrenheitCelsius(double Fahrenheit)
            {
                
            }


        }
    }
}
