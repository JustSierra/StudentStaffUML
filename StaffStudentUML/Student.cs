using System;
using System.Collections.Generic;
using System.Text;

namespace StaffStudentUML
{
    class Student : Person
    {
        public string Program { get; set; }
        public int Year { get; set; }
        public double Fee { get; set; }

        public Student(string name, string address, string program, int year, double fee) : base(name, address)
        {
            Program = program;
            Year = year;
            Fee = fee;
        }

        public Student() 

        public override string ToString()
        {
            return 
        }

    }
}
