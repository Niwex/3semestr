using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Dog : IAnimal
    {
        string name;
        string poroda;
        double ves = default;
        int month = default;

        public Dog(string name, string poroda)
        {
            this.name = name; this.poroda = poroda;
        }
        public double Korm(double ves, int month)
        {
            this.ves = ves; this.month = month;
            if (month <= 12)
            {
                if (month < 1)
                    return ves * 15;
                if (month < 3 && month >= 1)
                    return ves * 25;
                if (month < 4 && month >= 3)
                    return ves * 30;
                else
                    return ves * 35;
            }
            else
            {

                if (ves < 5 && ves >= 2)
                    return ves * 75;
                if (ves <= 10 && ves >= 5)
                    return 175 * ves;
                if (ves < 40 && ves > 10)
                    return ves * 470;
                else
                    return ves * 600;
            }
        }
        public void show()
        {
            Console.WriteLine(name);
            Console.WriteLine(poroda);
            Console.WriteLine(ves);
            Console.WriteLine(month);
        }

    }
}

