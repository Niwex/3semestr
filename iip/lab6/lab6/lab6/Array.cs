using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace lab6
{
    class Array:IArray<Array>
    {
        public char[] text { get; set; }
        public int n { get; set; }

        public Array(string a, int n)
        {
            this.text = new char[n];
            for (int i = 0; i < n; i++)
            {
                this.text[i] = a[i];
            }
            this.n = n;
        }

        public string getString()
        {
            string temp = new string(this.text);
            return temp;
        }

        

        public void sliyanie(IArray<Array> b)
        {
            var temp1 = this.text.Concat(b.text).Distinct();
            char[] k = new char[temp1.Count()];
            int j = 0;
            this.n = temp1.Count();
            foreach (char x in temp1)
            {
                k[j] = x;
                j++;
            }
            this.text = new char[k.Length];
            for (int i = 0; i < n; i++)
            {
                this.text[i] = k[i];
            }
        }
        

            
        

        public void showElemString(int i)
        {
            string a = new string(this.text);
            Console.WriteLine("Строка: " + a);
            Console.WriteLine("Элемент " + i + ": " + this.text[i]);
        }
    }
}
