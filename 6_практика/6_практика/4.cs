//namespace _6_практика
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Random rnd = new Random();
//            int[] a = new int[17];
//            for (int i = 0; i < a.Length; i++)
//            {
//                a[i] = rnd.Next(-10, 10+1);
//                Console.Write(a[i] + " ");
//            }
//            Console.WriteLine();
//            double sum = 0;
//            int z = 0;
//            for (int i = 0; i < a.Length; i += 2) // Похожа на предыдущию задачку
//            {
//                if (a[i] > 0 && a[i] % 2 != 0)
//                {
//                    sum += a[i]; // Ну а это из 2 задачки взято
//                    z++;
//                }
//            }
//            if (z > 0)
//            {
//                double arif = sum / z; // Кстати пока делал ее играла DADDY!DADDY!DO! прекрасно было
//                Console.WriteLine(arif);
//            }
//        }
//    }
//}
