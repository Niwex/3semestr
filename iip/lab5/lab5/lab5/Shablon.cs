using System;
using System.Collections.Generic;
using System.Text;

namespace lab5
{
    class Shablon<T> 
    {
        public T value;

        public Shablon(T a)
        {
            value = a;
        }
        public static Shablon<T> operator +(Shablon<T> a, Shablon<T> b)
        {
            return new Shablon<T>(Sum(a.value, b.value));
        }
        public static Shablon<T> operator -(Shablon<T> a, Shablon<T> b)
        {
            return new Shablon<T>(Mines(a.value, b.value));
        }
        private static T Sum(T a, T b)
        {
            return (dynamic)a + (dynamic)b;
        }
        private static T Mines(T a, T b)
        {
            if (a is string || a is char)
            {
                string temp = a as string;
                string temp1 = b as string;
                temp = temp.Replace(temp1, "");
                Console.WriteLine(temp);
                return (dynamic)temp;
            }
            return (dynamic)a - (dynamic)b;
        }
    }
}
