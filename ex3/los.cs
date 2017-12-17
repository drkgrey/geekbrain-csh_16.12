using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ex3
{
 
    class Los
    {
        List<student> list = new List<student>();

        public Los(params student[] Args)
        {
            foreach( var item in Args)
            {
                list.Add(item);
            }
        }
        public Los(string pathToCSV)
        {
            
            using (StreamReader sr = new StreamReader(pathToCSV))
            {
               
                while (!sr.EndOfStream)
                {
                    string[] s = sr.ReadLine().Split(';');
                    list.Add(new student(s[0], s[1], int.Parse(s[2]), int.Parse(s[3])));
                } 
            }
            
        }
        public void SortByCourse()
        {
            list = list.OrderBy(item => item.course).ToList();
        }
        public int On5and6()
        {
            int i = 0;
            foreach( var item in list)
            {
                if (item.course == 5 || item.course == 6) i++;
            }
            return i;
        } //вычисление количесвтва студентов на заданных курсах
        public void onCourse()
        {
            Console.WriteLine("введите курсы");
            string s = Console.ReadLine();
            char[] dem = { ',', '.', ' ' };
            var a = s.Split(dem);
            foreach (var item in a)
            {
                int i = 0;
                foreach (var item1 in list)
                {
                    try
                    {
                        if (item1.course == int.Parse(item)) i++;
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine(e.Message);
                        Console.WriteLine("Ошибка!ESC - прекратить выполнение программы");
                        if (Console.ReadKey().Key == ConsoleKey.Escape) return;
                    }
                }
                Console.WriteLine($"студентов на {item} курсе - {i}");
            }
        } //вычисление количества студентов на произвольных курсах( введенных строкой) 
        public void Numberof18_20ByCourses()
        {
            int[] mass = new int[6];
            for (int i = 1; i<=6; i++)
            {
                foreach( var item in list)
                {
                    if (item.course == i) mass[i-1]++;
                }
                Console.WriteLine($"учеников возраста от 18 до 20 на {i} курсе - {mass[i-1]}");
            }
            
        }
        public void NumberofAgeByCourses() 
        {
            Console.WriteLine("введите мин возраст");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("введите мах возраст");
            int b = int.Parse(Console.ReadLine());
            int[] mass = new int[6];
            for (int i = 1; i <= 6; i++)
            {
                foreach (var item in list)
                {
                    if (item.course == i && item.age<=b && item.age>=a) mass[i - 1]++;
                }
                Console.WriteLine($"учеников возраста от {a} до {b} на {i} курсе - {mass[i - 1]}");
            }

        }

        public void SortByAge()
        {
            list = list.OrderBy(item => item.age).ToList();
        }
        public void SortByAgeAndCourse()
        {
            List<student> n = new List<student>();
            for (int i = 1; i <= 6; i++)
                {
                List<student> t = new List<student>();
                foreach ( var item in list)
                {
                    if (item.course == i)
                    {
                        t.Add(item);
                    }
                }
                t = t.OrderBy(item => item.age).ToList();
                n.AddRange(t);
                    }
            list = n;
        }
        public void Print()
        {
            foreach( var item in list)
            {
                item.Print();
            }
            Console.WriteLine();
        }
        
    }
}
