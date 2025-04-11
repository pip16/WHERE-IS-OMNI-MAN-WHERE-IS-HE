using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parktika_5
{
    internal class _19
    {
        static void vklad(double n)
        {
            int i = 0;
            while (n < 100000)
            {
                Console.Write("количество месяцев ");
                Console.WriteLine(i++);
                double z = n * 0.02;
                n = n + z;
                Console.WriteLine(n);
            }
        }
        public static void Main(string[] args)
        {
            vklad(1000);
        }
        
    }
}
