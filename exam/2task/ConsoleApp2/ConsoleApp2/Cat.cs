using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Cat : IAnimal
    {
        string name;
        string poroda;
        double ves = default;
        int month = default;


        public Cat(string name, string poroda)
        {
            this.name = name; this.poroda = poroda;
        }
        public double Korm(double ves, int month)
        {
            this.ves = ves; this.month = month;
            if (month<6)
            {
                if (ves < 2.5)
                    return 35;
                if (ves < 3.5 && ves>= 2.5)
                    return 50;
                if (ves < 4.5 && ves >= 3.5)
                    return 70;
                else
                    return 85;
            }
            else
            {
                
                if (ves < 3.5)
                    return 25;
                if (ves < 4.5 && ves >= 3.5)
                    return 40;
                if (ves < 5.5 && ves >= 4.5)
                    return 55;
                else
                    return ves*12;

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
