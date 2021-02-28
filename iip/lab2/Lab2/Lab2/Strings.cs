using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2
{
    public abstract class Strings
    {
        public string text;
        public string getString()
        {
            return this.text;
        }
        
        public void showString()
        {
            Console.WriteLine(this.text);
        }
            
        
    }
}
