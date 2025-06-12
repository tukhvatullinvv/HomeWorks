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
            for (int i = 0; i < n / 2; i++)
            {
                int j = mass[i];
                mass[i] = mass[(n - 1) - i];
                mass[(n - 1) - i] = j;
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}", mass[i]);
            }
            Console.ReadKey();
        }
    }
}
