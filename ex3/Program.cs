using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Подсчитать количество студентов:
//а) учащихся на 5 и 6 курсах;
//б)* подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся(частотный
// массив);
//в) отсортировать список по возрасту студента;
//г) ** отсортировать список по курсу и возрасту студента.

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Los los = new Los(
                new student() { lastName = "fam1", firstName = "im1", age = 17, course = 1 },
                new student() { lastName = "fam2", firstName = "im2", age = 18, course = 3 },
                new student() { lastName = "fam3", firstName = "im3", age = 19, course = 5 },
                new student() { lastName = "fam4", firstName = "im4", age = 20, course = 5 },
                new student() { lastName = "fam5", firstName = "im5", age = 20, course = 6 },
                new student() { lastName = "fam6", firstName = "im6", age = 21, course = 1 },
                new student() { lastName = "fam7", firstName = "im7", age = 22, course = 6 },
                new student() { lastName = "fam8", firstName = "im8", age = 17, course = 5 },
                new student() { lastName = "fam9", firstName = "im9", age = 18, course = 5 },
                new student() { lastName = "fam10", firstName = "im10", age = 19, course = 6 },
                new student() { lastName = "fam11", firstName = "im11", age = 17, course = 6 }
                );
            los.Numberof18_20ByCourses();
            Console.WriteLine(los.On5and6());
            los.SortByAge();
            los.Print();
            los.SortByAgeAndCourse();
            los.Print();

            los.onCourse();
            
            los.NumberofAgeByCourses();
            Console.ReadKey();
        }
    }
}
