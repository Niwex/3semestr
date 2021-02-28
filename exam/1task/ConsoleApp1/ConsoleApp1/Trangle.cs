using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Trangle
    {
        int a , b , c;
        public Trangle()
        {

        }
        public Trangle(int a , int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double S ()
        {
            double p =( a + b + c )/ 2;
            return Math.Sqrt(p*(p-a)*(p-b)*(p-c));
        }
         public double P()
        {
            return a + b + c;
        }
        public void changeTrangle(int a, int b, int c)
        {
            this.a = a; this.b = b; this.c = c;
        }
        public bool DoesExist()
        {
            bool returnValue = false;
            if (a + b > c && a + c > b & b + c > a)
                returnValue = true;
            return returnValue;
        }
    }
}
