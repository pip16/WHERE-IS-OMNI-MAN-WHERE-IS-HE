namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            string a = "abcdefghijklmnopqrstuvwxyz";
            string b = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string c = "0123456789";
            string abc = a + b + c;
            char[] pass = new char[8];
            for (int i = 0; i < 8; i++)
            {
                int rand = rnd.Next(0, abc.Length);
                pass[i] = abc[rand];
            }
            string res = new string(pass);
            Console.WriteLine(res); //Я устал лазить по сайтам в поисках хоть какого то понятия как это делать
        }
    }
}
