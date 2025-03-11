namespace Task2_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 4х-значное число:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = a / 1000;
            int c = (a % 1000) / 100;
            int d = (a % 100) / 10;
            int e = a % 10;
            Console.WriteLine("{0}{3}{2}{1}", b, c, d, e);
            Console.ReadKey();

        }
    }
}
