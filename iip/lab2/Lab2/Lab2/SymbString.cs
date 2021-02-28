using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2
{
    
    class SymbString : Strings
    {
        public SymbString(string str)
        {
            this.text = str;
        }
        public static string operator +(SymbString a, SymbString b)
        {
            var temp = a.getString().Concat(b.text);
            char[] tempstring = new char[temp.Count()];
            int i = 0;
            foreach(char x in temp)
            {
                tempstring[i] = x;
                i++;
            }
            string str = new string(tempstring);
            return str;
        }
    }
}
