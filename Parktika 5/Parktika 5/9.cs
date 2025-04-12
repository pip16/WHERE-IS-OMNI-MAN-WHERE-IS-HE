//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Praktika5
//{
//    internal class _9
//    {
//        static double sqrt(double n)
//        {
//            double sum = 0;
//            double count = 1;
//            while (count <= n)
//            {
//                sum = sum + (count * count);
//                count = count + 1;
//            }
//            return sum;
//        }

//        public static void Main(string[] args)
//        {
//            double x = sqrt(7);
//            Console.WriteLine(x); 
//        }
//    }
//}
////1 * 1 = 1, 2 * 2 = 1 + 3, 3 * 3 = 1 + 3 + 5, 4 * 4 = 1 + 3 + 5 + 7, …, n * n = 1 + 3 + 5 + 7 + 9 + … +( — 1).