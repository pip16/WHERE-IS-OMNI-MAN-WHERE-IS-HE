using System.ComponentModel.Design;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int number = int.Parse(Console.ReadLine());
            //int numbr = int.Parse(Console.ReadLine());
            //Random rna = new Random();
            //Console.WriteLine(rna.Next());
            //Console.WriteLine(rna.Next(5));
            //Console.WriteLine(rna.Next(-5, 5));
            //Console.WriteLine("конвертируемые числа");
            //Console.WriteLine(rna.Next(numbr, number));

            //float a = 3.2f;
            //decimal b = 2.6m;
            //double c = 4.5;
            //int d = (int)a;
            //int f = (int)b;
            //int g = (int)c;
            //int r = d + f + g;
            //Console.WriteLine(r);

            //int num = 3;
            //double num2 = 2.6;
            //Console.WriteLine(num + num2);

            //int A = int.Parse(Console.ReadLine());
            //Console.WriteLine(A * A);

            //Double B = Double.Parse(Console.ReadLine());
            //double a = Math.Round(B, 3);
            //Console.WriteLine(a);

            //double e = double.Parse(Console.ReadLine());
            //double blabla = Math.Round(e, 1);
            //Console.WriteLine(blabla);

            //int numbr = int.Parse(Console.ReadLine());
            //Console.Clear();
            //Console.WriteLine("Вы ввели число");
            //Console.WriteLine(numbr);

            //int numer = int.Parse(Console.ReadLine());
            //Console.Clear();
            //Console.WriteLine(numer);
            //Console.WriteLine("Вот какое число вы ввели");

            //Console.WriteLine("1 13 49");
            //Console.WriteLine("7  15  100");

            //float z; int a = 1, b = 2, c = 3;
            //const int m = 3;
            //z = (a + b + c) / m;
            //Console.WriteLine(z);

            //double a = int.Parse(Console.ReadLine());
            //double b = int.Parse(Console.ReadLine());
            //double c = (a + b) / 2;
            //Console.WriteLine(c);

            //int x = int.Parse(Console.ReadLine());
            //int n = int.Parse(Console.ReadLine());
            //double c = double.RootN(x, n);
            //Console.WriteLine(c);

            //int v = int.Parse(Console.ReadLine());
            //int p = int.Parse(Console.ReadLine());
            //int m = p * v;
            //Console.WriteLine(m);

            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            if (a != 0)
            {
                double x = -b / a;
                Console.WriteLine(x);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("а должно быть не равно 0");
                Console.ReadKey();
            }

        }
    }
}
