using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 3.14;
            int b = Convert.toInt32(a);
            
            Console.WriteLine("Your number is: " + a);
            
            Console.ReadKey();
        }
    }
}