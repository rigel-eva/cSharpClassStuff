using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._9._12___Dates_and_Imaginary_numbers
{
    class ComplexNumber
    {
        public double Real { get; set; }
        public double Imaginary { get; set; }
        public ComplexNumber()
        {
            Real = 0;
            Imaginary = 0;
        } 
        public ComplexNumber(double realPart, double imaginaryPart)
        {
            Real = realPart;
            Imaginary = imaginaryPart;
        }
        public override string ToString()
        {
            if(Real > 0 || Real < 0)
            {
                if (Imaginary > 0)
                {
                    return $"{Real}+{Imaginary}i";//Need to ensure that the imaginary has the + sign here ...
                }
                else if (Imaginary < 0)
                {
                    return $"{Real}{Imaginary}i";//Due to the fact Imaginary is negative it will return a-bi
                }//If there is just the real we are covered by the last return.
            }else if (Imaginary > 0 || Imaginary < 0)
            {
                return $"{Imaginary}i";//Just return the imaginary then ...
            }
            return $"{Real}";//If all else fails, return the real.
        }
        public static ComplexNumber operator +(ComplexNumber c1, ComplexNumber c2)//Ah operator overloading ... how I missed ye.
        {
            return new ComplexNumber(c1.Real + c2.Real, c1.Imaginary + c2.Imaginary);
        }
        public static ComplexNumber operator +(ComplexNumber c1, double c2)
        {
            return new ComplexNumber(c1.Real + c2, c1.Imaginary);
        }
        public static ComplexNumber operator -(ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber(c1.Real - c2.Real, c1.Imaginary - c2.Imaginary);
        }
        public static ComplexNumber operator -(ComplexNumber c1, double c2)
        {
            return new ComplexNumber(c1.Real - c2, c1.Imaginary);
        }
        public static ComplexNumber operator *(ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber(c1.Real * c2.Real - c1.Imaginary * c2.Imaginary, c1.Real * c2.Real + c1.Imaginary * c2.Imaginary);
        }
        public static ComplexNumber operator *(ComplexNumber c1, double c2)
        {
            return new ComplexNumber(c1.Real * c2, c1.Imaginary * c2);
        }
        //Going to add division later because ... well fuck division ...
    }
}
