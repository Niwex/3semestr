using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    class HexString : NumbString
    {
        public HexString(string str)
        {
            
            
            
                try
                {
                    this.text = str;
                    this.temp = Convert.ToInt32(this.text, 16);
                    
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            
        }

        public static string operator +(HexString a, HexString b)
        {
            try
            {
                int tempA = Convert.ToInt32(a.getString(), 16);
                int tempB = Convert.ToInt32(b.getString(), 16);
                return Convert.ToString(tempA + tempB, 16);

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "ERROR";
            }
        }
        
    }
}
