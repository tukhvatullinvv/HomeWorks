namespace Task4_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            for (; i < a; i *= 2) { }
            if (i == a)
            {
                Console.WriteLine("{0} - степень 2", a);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("{0} - не степень 2", a);
                Console.ReadKey();
            }
        }
    }
}
