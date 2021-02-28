using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace lab6
{
    interface IArray<T>
    {
        public char[] text { get; set; }
        public int n { get; set; }

        public string getString();
        public void sliyanie(IArray<T> b);
        public void showElemString(int i);
        public static string sceplenie(IArray<T> a, IArray<T> b)
        {
            Console.WriteLine(a.text.Length + " " + b.text.Length);
            char[] temp = new char[a.text.Length + b.text.Length];
            int j = 0;
            for (int i = 0; i < temp.Length; i = i + 2)
            {
                if (a.n >= b.n)
                {
                    temp[i] = a.text[j];
                    if (b.n > j)
                    {
                        temp[i + 1] = b.text[j];
                    }
                    else
                    {
                        i--;
                    }
                    j++;
                }
                else
                {

                    if (a.n > j)
                    {
                        temp[i] = a.text[j];
                    }
                    else
                    {
                        i--;
                    }
                    temp[i + 1] = b.text[j];
                    j++;
                }
            }
            string temp2 = new string(temp);
            return temp2;
        }
    }
}
