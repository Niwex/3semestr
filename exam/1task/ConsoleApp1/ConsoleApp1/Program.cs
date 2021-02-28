using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Trangle trangle = new Trangle(5, 6, 12);
            Console.WriteLine(trangle.DoesExist());
            
            trangle.changeTrangle(5, 5, 5);
            Console.WriteLine(trangle.DoesExist());
            Console.WriteLine(trangle.S());
            Console.WriteLine(trangle.P());
            
            
            Console.WriteLine("Hello World!");
        }
    }
}
