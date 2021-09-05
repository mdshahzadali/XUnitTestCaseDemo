using System;

namespace XunitConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOperation mathOperation = new MathOperation();
            int c = mathOperation.AddNumber(10, 10);
            Console.WriteLine(c);
            Console.ReadLine();
        }
    }
}
