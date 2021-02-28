using System;
using System.Collections.Generic;
using System.Text;

namespace lab4
{
    class Class1
    {
        int year, day;
        public Class1(int new_year, int day)
        {
            if (new_year > 2020 || new_year<1 )
                throw new exp();
            this.year = new_year;
            if (day > 365 || day < 1)
                throw new exp();
            this.day = day;
        }

        public void SetYear(int newYear)
        {
            if (newYear > 2020 || newYear < 1 )
                throw new exp("Wrong year");
            this.year = newYear;
        }
        public void SetDay(int day)
        {
            if(day > 365 || day < 1)
                throw new exp("Wrong day");
            this.day = day;
        }

        public void Show()
        {
            Console.WriteLine("year - " + this.year + ", day - " + this.day);
        }
        
    }
}
