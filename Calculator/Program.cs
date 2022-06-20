using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number 1");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter munber 2");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Choose an operation (+/-/*//):");
            char operation = Convert.ToChar(Console.ReadLine());
            switch (operation)
            {
                case '+':
                    Addition(num1, num2);
                    break;
                case '/':
                    Division(num1, num2);
                    break;
                case '*':
                    Multiplicansion(num1, num2);
                    break;
                case '-':
                    Subtraction(num1, num2);
                    break;
            }
            //Дописать приложение.
            //Добавить функции умножения и вычитания.
        }
        public static void Addition(int a, int b)
        {
            int result = a + b;
            Console.WriteLine($"{a} + {b} = {result}");
        }
        public static void Multiplicansion(int a, int b)
        {
            double result = a * b;
            Console.WriteLine($"{a} * {b} = {result}");
        }
        public static void Division(int a, int b)
        {
            double result = (double)a / (double)b;
            Console.WriteLine($"{a} / {b} = {result}");
        }
        public static void Subtraction(int a, int b)
        {
            double result = (double)a - (double)b;
            Console.WriteLine($"{a} - {b} = {result}");
        }
    }
} 