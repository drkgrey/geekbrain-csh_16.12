using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5
{
    class Program
    {
        static int MaxP(List<int> ab)
        {
            int max1 = ab.Max();
            List<int> abc = new List<int>();
            abc.AddRange(ab);
            abc.Remove(abc.Max());
            int max2 = abc.Max();
            int maxp = max1 * max2;
            return maxp;
        }
        //static void print(List<int> ab)
        //{
        //    foreach(var item in ab)
        //    {
        //        Console.WriteLine(item);
        //    }
        //    Console.WriteLine();
        //}

        static void Main(string[] args)
        {
            

            Random r = new Random();
            int[] a = new int[10000000];
            for (int i = 0; i<a.Length; i++)
            {
                a[i] = r.Next(0, 100000);
            }
            List<int> ab = new List<int> { a[0],a[1],a[2],a[3],a[4],a[5],a[6],a[7]};
            int maxp = MaxP(ab);
            DateTime d = DateTime.Now;
            for (int i = 8; i < a.Length; i++)
            {
                
                ab.Remove(ab.ElementAt(0));
               
                ab.Add(a[i]);
              
                if (MaxP(ab) > maxp)
                {
                    maxp = MaxP(ab);
                }
             }

            Console.WriteLine($"{maxp}");
            Console.WriteLine(DateTime.Now - d);

            Console.ReadKey();


        }
    }
}
