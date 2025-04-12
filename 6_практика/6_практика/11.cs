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
//                a[i] = rnd.Next(0, 51);
//                Console.Write(a[i] + " ");
//            }
//            int z = 0; // Если вы не поняли то я z как счетчик часто использую
//            for (int i = 0; i < n; i++)
//            {
//                if (a[i] % 2 == 0)
//                {
//                    z++;
//                }
//            }
//            int[] b = new int[z]; // новый массивчик подъехал
//            int ind = 0;
//            for (int i = 0; i < n; i++)
//            {
//                if (a[i] % 2 == 0)
//                {
//                    b[ind] = a[i];
//                    ind++;
//                }
//            }
//            Console.WriteLine();
//            if (b.Length == 0)
//            {
//                Console.WriteLine("Четных нема, груздь (черемша)");
//            }
//            else
//            {
//                Console.WriteLine(string.Join(" ", b)); // ну пожалуй хватит, там без страницы 8 заданий но поскольку я пропустил некоторые решил их так восполнить
//            }
//        }
        
//    }
//}
