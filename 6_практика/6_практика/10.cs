//namespace _6_практика
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Random rnd = new Random();
//            int n = int.Parse(Console.ReadLine());
//            if (n <= 0)
//            {
//                Console.WriteLine("Я не знаю отрицательных чисел :/");
//            }
//            int[] a = new int[n];
//            for (int i = 0; i < a.Length; i++)
//            {
//                a[i] = rnd.Next(-1, 11);
//                Console.Write(a[i] + " ");
//            }
//            bool Neggaaaaa = false; // Да да не поймете скорее всего, но это отсылка на GTA 5
//            for (int i = 0; i < n; i++)
//            {
//                if (a[i] < 0)
//                {
//                    Neggaaaaa = true;
//                }
//            }
//            Console.WriteLine(Neggaaaaa);
//        }
//    }
//}