//namespace _6_практика
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            double[] a = new double[8];
//            for (int i = 0; i < a.Length; i++)
//            {
//                a[i] = double.Parse(Console.ReadLine());
//            }
//            double sum = 0;
//            int z = 0; //Количество знаков хотя по идее можно и без и просто на 8 делить
//            for (int i = 0; i < a.Length; i++)
//            {
//                if (a[i] > 0)
//                {
//                    sum += a[i];
//                    z++; // Пишу я же, после много время думаний понял что отрицательные не считаются
//                }
//            }
//            double arif = sum / z;
//            Console.WriteLine($"Среднее", arif);
//        }
//    }
//}
