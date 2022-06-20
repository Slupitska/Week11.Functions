using System;

namespace Draft4
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine("Please enter the Fahrenheit you wish to convert");
            //Formula form = new Formula();
            form.F = double.Parse(Console.ReadLine());
            form.calculate();
            Console.WriteLine(F + "Fahrenheit correspond to " + form.C + "Degrees celcius");
        }
        public static void calculate()
        {
            C = (5.0 / 9.0) * (F - 32);
        }

    }
}
