using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    class NumbString : Strings
    {
        public int temp;
        public void showBin()
        {
            
            Console.WriteLine(Convert.ToString(temp, 2));
        }
        public void showOct() 
        {

            Console.WriteLine(Convert.ToString(temp, 8));
        }

        public void showDec() 
        {


            Console.WriteLine(Convert.ToString(temp, 10));
        }


        public void showHex()
        {
            
            Console.WriteLine(Convert.ToString(temp, 16));
        }


    }
}

