using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._04._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            //4.1
            Console.WriteLine("Введите число");
            double x = Convert.ToDouble(Console.ReadLine());
            Math.Pow(Math.Sin(x), 2);
            if ((x > 0))
            {
                double y = Math.Pow(Math.Sin(x), 2);
            }
            else
            {
                double y = 1 - 2 * Math.Sin(Math.Pow(x, 2));
            }

            //4.6
            Console.WriteLine("Введите число a");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число b");
            double b = Convert.ToDouble(Console.ReadLine());
           
            if (a>b)
            {
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine(a);
            }
           

            //4.9
            Console.WriteLine("Введите скорсть в км/ч k");
            double k = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите скорость в м/с m");
            double m = Convert.ToDouble(Console.ReadLine());
            double k1 = k * 1000 / 3600;
            if (k > m)
            {
                Console.WriteLine(k + "км/ч");
            }
            else
            {
                Console.WriteLine(m + "м/с");
            }

            //4.10
            Console.WriteLine("Введите первое число");
            double а = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число r");
            double r = Convert.ToDouble(Console.ReadLine());
            double s1 = (a * a);
            double s2 = (2 * 3.14 * Math.Pow(r, 2));
            if (s1 > s2)
            {
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine(r);
            }
            Console.ReadKey();














        }
    }
}
