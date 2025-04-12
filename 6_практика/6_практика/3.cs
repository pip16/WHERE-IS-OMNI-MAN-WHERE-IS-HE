//namespace _6_практика
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Random rnd = new Random();
//            int[] a = new int[20];
//            for (int i = 0; i < a.Length; i++)
//            {
//                a[i] = rnd.Next(-10, 10+1);
//                Console.Write(a[i] + " ");
//            }
//            int sum = 0;
//            for (int i = 1; i < a.Length; i += 2) // Сначала пытался решить делением индекса на на 2 с отстатком 1 но нашел такой вот способ полегче
//            {
//                if (a[i] < 0)
//                {
//                    sum += a[i];
//                }
//            }
//            Console.WriteLine();
//            Console.WriteLine();
//            Console.WriteLine(sum);
//        }
//    }
//}
