using System;

namespace lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Shablon<string> str1 = new Shablon<string>("asdaddaddadaaad");
            Shablon<string> str2 = new Shablon<string>("ssss");
            Shablon<int> int1 = new Shablon<int>(5);
            Shablon<int> int2 = new Shablon<int>(6);

            Shablon<string> sumstr = str1 - str2;
            Shablon<int> sumint = int1 + int2;
            Console.WriteLine(sumint.value);
            Console.WriteLine(sumstr.value);
            
        }
    }
}
