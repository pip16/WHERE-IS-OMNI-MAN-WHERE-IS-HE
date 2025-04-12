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
//                a[i] = rnd.Next(0, 11);
//                Console.Write(a[i] + " ");
//            }
//            bool chet = true;
//            for (int i = 0; i < n; i++)
//            {
//                if (a[i] % 2 != 0) // Вы не поверите но опять заиграл DADDY!DADDY!DO!
//                {
//                    chet = false;
//                }
//            }
//            Console.WriteLine();
//            Console.WriteLine("DADDY!DADDY!DO!");
//            Console.WriteLine(chet);
//        }
//    }
//}
