namespace Task4_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            for (; a >= 10; i++)
            {
                a /= 10;
            }
            Console.WriteLine("{0}", i);
            Console.ReadKey();
        }
    }
}
