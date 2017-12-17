using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3
{
    
    class student
    {
        public string lastName;
        public string firstName;
        public int course;        public int age;        public student()
        {
            lastName = "";
            firstName = "";
            course = 0;
            age = 0;
        }                public student(string lastName, string firstName, int course, int age)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.course = course;
            this.age = age;
        }        public void Print()
        {
            Console.WriteLine($"{lastName} {firstName} - {course}, {age}");
        }        
    }
}
