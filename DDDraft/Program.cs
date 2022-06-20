namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int Celsius = 15;
            Console.WriteLine("Цельсия\tФаренгейта");
            for (int i = Celsius; i < 30; i++)
            {
                Console.WriteLine("{0}\t{1}", i, i * 1.8 + 32);
            }
            Console.ReadKey();
        }
    }
}