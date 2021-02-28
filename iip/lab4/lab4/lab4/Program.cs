using System;
using System.Collections.Generic;
using System.IO;

namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Class1 first = new Class1(2004, 21);
                first.Show();
                Class1 second = new Class1(20, 15);
                second.Show();
                first.SetYear(0);
                first.Show();
            }
            catch (exp ex)
            {
                Console.WriteLine(ex.message);
                ex.HowTofix();
                Console.WriteLine(ex.TargetSite);
                Console.WriteLine(ex.StackTrace);
                
                
            }

            
        }
    }
}
