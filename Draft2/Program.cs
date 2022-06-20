using System;

namespace Draft2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Из Цельсия в Фаренгейт: °C = (°F − 32) x 5 / 9
            //Из Фаренгейта в Цельсии:  °F = (°C × 9 / 5) +32

            Console.WriteLine("convert Celsium degrees to Fahrenheit (enter 1) or vice versa (enter 2)?:");
            char operation = Convert.ToChar(Console.ReadLine());

            if(char == 1)
            {
                Console.WriteLine("Enter the temperature in Celsium degrees:");
                int Cels = Convert.ToInt32(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Enter the temperature in Fahrenheit:");
                int Fahr = Convert.ToInt32(Console.ReadLine());
            }
            
            switch (operation)
            {
                case '1':
                ConvertCF;
                break;

                case '2':
                ConvertFC;
                break;
            }
            public static string ConvertCF()
            {
                double resultC = Cels * 9.0 / 5.0 + 32.0;
            }

            public static string ConvertFC()
            {
                double resultF = (Fahr - 32.0) * 5.0 / 9.0;
            }

            //Console.WriteLine($"{Farh}°F = {double resultF} °C.");
            //Console.WriteLine($"{Cels}°C = {double resultC} °F.");
            
        } 
    }
}
