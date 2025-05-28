namespace Task5_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            int[] mass = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                mass[i] = rnd.Next(0, 11);
                Console.WriteLine("{0}", mass[i]);
            }
            Console.WriteLine("<-->");
            int[] massRev = new int[n];
            for (int i = 0; i < n; i++)
            {
                massRev[i] = mass[(n - 1) - i];
                Console.WriteLine("{0}", massRev[i]);
            }
            Console.ReadKey();
        }
    }
}
