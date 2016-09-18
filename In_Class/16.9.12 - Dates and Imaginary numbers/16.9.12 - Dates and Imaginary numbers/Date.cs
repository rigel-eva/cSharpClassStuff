using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._9._12___Dates_and_Imaginary_numbers
{
    class Date
    {
        public int Day { get; private set; }
        public int Month { get; private set; } 
        public int Year { get; private set; }
        Date(int year, int month, int day)
        {
            Year = year;
            Month = month;
            Day = day;
        }
       override public string ToString()
        {
            return $"{Month:d2}/{Day:d2}/{Year:d2}";//Well that's neat, string interpolation works here, though not exactly the same as Ruby.
        }
    }
}
