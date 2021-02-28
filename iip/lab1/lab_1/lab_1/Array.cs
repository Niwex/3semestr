using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace lab_1
{
    class Array
    {
        public char[] text;
        private int n;

        public Array(string a, int n)
        {
            this.text = new char[n];
            for (int i = 0; i < n; i++)
            {
                this.text[i] = a[i];
            }
            this.n = n;
        }
        ~Array()
        {
            
        }
        public string getString()
        {
            string temp = new string(this.text);
            return temp;
        }

        public static string sceplenie(Array a, Array b)
        {
            Console.WriteLine(a.text.Length + " " + b.text.Length);
            char[] temp = new char[a.text.Length+b.text.Length];
            int j = 0;
            for(int i = 0; i<temp.Length;i=i+2)
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
                    temp[i+1] = b.text[j];
                    j++;
                }
            }
            string temp2 = new string(temp);
            return temp2;
        }

        public void sliyanie(Array b)
        {
            
            var temp1 = this.text.Concat(b.text).Distinct();
            char[] k = new char[temp1.Count()];
            int j = 0;
            this.n = temp1.Count();
            foreach(char x in temp1)
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
            Console.WriteLine("Строка: "+a);
            Console.WriteLine("Элемент "+ i+": "+this.text[i]);
        }
        
    }
}
