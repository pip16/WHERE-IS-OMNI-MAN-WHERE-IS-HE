using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika5
{
    internal class _29
    {
        static double Ski1(double n)
        {
            double x = (1.1 * n) + 10; 
            return x;
        }

        static double Ski2(double n)
        {
            double y = 0;
            for (int day = 1; day <= n; day++)
            {
                y += 10 * Math.Pow(1.1, day - 1); 
            }
            return y;
        }

        public static void Main(string[] args)
        {
            double x = Ski1(5);
            double y = Ski2(5);
            Console.WriteLine("пробег:");
            Console.WriteLine(x);
            Console.WriteLine("путь пройденный:");
            Console.WriteLine(y);
        }
    }
}
