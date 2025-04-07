namespace задание_3._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("а");
            for (int i = 10; i <= 25; i++)
            {
                double res1 = i + 0.4;
                Console.WriteLine($"{i} {res1}");
            }

            Console.WriteLine("б");
            for (int i = 25; i <= 35; i++)
            {
                double res21 = i + 0.5;
                double res22 = i - 0.2;
                Console.WriteLine($"{i} {res21} {res22}");
            }

        }
    }
}
