using System;
using System.Text.RegularExpressions;
namespace _16._9._12___Chapter_4 {
    public class Gradebook
    {
        private string _CourseName;//Property
        //Constructor
        public Gradebook(string Coursename)
        {
            _CourseName = Coursename;
        }
        public void DisplayMessage()//Public Method
        {
            Console.WriteLine("CourseName: {0}",_CourseName);
        }
        public string CourseName
        {
            get//So Similar to Objective C, and Swift ... neat
            {
                return _CourseName;
            }
            private set
            {
                _CourseName = value;
            }
        }
    }
}
