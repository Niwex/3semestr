using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class SearchInfo
    {
        public static void Func(IAnimal a, IAnimal b)
        {
            double ves = Convert.ToDouble(Console.ReadLine());
            int month = Convert.ToInt32(Console.ReadLine());
            double temp1 = a.Korm(ves, month);
            ves = Convert.ToDouble(Console.ReadLine());
            month = Convert.ToInt32(Console.ReadLine());
            double temp2 = b.Korm(ves, month);
            if (temp1 > temp2)
            {
                a.show();
            }
            else
            {
                b.show();
            }
        }
    }
}
