using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._14___Date
{
    class Date
    {
        public int Day { get; private set; }
        public int Month { get; private set; } 
        public int Year { get; private set; }
        public Date(int year, int month, int day)
        {
            Year = year;
            Month = month;
            Day = day;
        }
       override public string ToString()
        {
            return $"{Month:d2}/{Day:d2}/{Year:d2}";//Well that's neat, string interpolation works here, though not exactly the same as Ruby.
        }
        public void DisplayDate()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
