using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat a = new Cat("Dina", "Les");
            Dog b = new Dog("Tasa", "dog");
            SearchInfo.Func(a, b);
        }
    }
}
