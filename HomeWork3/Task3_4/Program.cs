namespace Task3_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int mid = b;
            if ((b > a && a > c) || (c > a && a > b))
            {
                mid = a;
            }
            if ((a > c && c > b) || (b > c && c > a))
            {
                mid = c;
            }
            Console.WriteLine("Медиана:{0}", mid);
            Console.ReadKey();
        }
    }
}
