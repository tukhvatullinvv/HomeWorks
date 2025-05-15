namespace Task4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            double k = 1;
            for (double i = 2; i <= a; i++)
            {
                k = k + (1 / i);
            }
            Console.WriteLine("{0}", k);
            Console.ReadKey();
        }
    }
}
