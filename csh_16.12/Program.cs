using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1. Изменить программу вывода функции так, чтобы можно было передавать функции типа
//double(double,double). Продемонстрировать работу на функции с функцией a* x^2 и функцией
//a* sin(x).
//q

namespace csh_16._12
{
    public delegate double Func(double a, double x);
    

    class Program
    {
        public static double st2( double a, double x)
        {
            double b = 0;
            return b = a * (x * x);
        }
        public static double sin(double a, double x)
        {
            double b = 0;
            return b = a * Math.Sin(x);
        }
        public static void show( Func F, double a, double x)
        {
            Console.WriteLine($"для значения x ={x}, значение введеной функции F(x) ={F(a,x)}");
        }
        static void Main(string[] args)
        {
            show(st2, 2, 4);
            show(sin, 5, 3.14/2);
            Console.ReadLine();

        }
    }
}
