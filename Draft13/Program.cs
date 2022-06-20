using System;

namespace CelsiusToFahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {

            
            //Приложение должно работать при помощи использования функций.
            //* Подсказка: одна функция конвертирует в Цельсий, вторая в Фаренгейт.
            FC();
        }
        public static void FC()
        {
            Console.Write("Temperature Converter. ");
            Console.Write("Choose the units of temperature measurement C or F: ");
            int i = 0;
            while (i < 10)
            {

                char userChoice = Convert.ToChar(Console.ReadLine().ToUpper());
                if (userChoice == 'F')
                {
                    Console.WriteLine("Enter temperature in Fahrenheit");
                    int far = Convert.ToInt32(Console.ReadLine());
                    int CelsiusSum = (far - 32) * 5 / 9;
                    Console.WriteLine($"Temperature is {CelsiusSum} C");
                    break;
                }
                else if (userChoice == 'C')
                {
                    Console.WriteLine("Enter temperature in Celsius");
                    int cel = Convert.ToInt32(Console.ReadLine());
                    int FahrengateSum = (cel * 9 / 5) + 32;
                    Console.WriteLine($"Temperature is {FahrengateSum} F");
                    break;
                }
                else
                {
                    i++;
                    Console.WriteLine($"Try again");
                    break;
                }
            }
        }
    }
}