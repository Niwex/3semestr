using System;
using System.Collections.Generic;
using System.Text;

namespace lab4
{
    class exp : Exception
    {

        int max_year { get; } = 2020;
        int max_day { get; } = 365;
        int min_year { get; } = 0;
        int min_day { get; } = 1;
        public string message = "Wrong year or day;";
        public exp(string message):base(message)
        {
            this.message = message;
        }
        public exp()
        {

        }
        public void HowTofix()
        {
            Console.WriteLine("Year should be from " + min_year + " to " + max_year);
            Console.WriteLine("Day should be from " + min_day + " to " + max_day);
        }
    }
}
