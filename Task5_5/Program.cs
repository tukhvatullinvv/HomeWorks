namespace Task5_5
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
                mass[i] = rnd.Next(-50, 50);
                Console.WriteLine("{0}", mass[i]);
            }
            Console.WriteLine("<---->");
            for (int i = 0; i < ((n / 2) - 1); i++)
            {
                for (int j = i + 1; j < (n / 2); j++)
                {
                    if (mass[i] > mass[j])
                    {
                        int t = mass[i];
                        mass[i] = mass[j];
                        mass[j] = t;
                    }
                }
            }
            for (int i = (n / 2); i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (mass[i] < mass[j])
                    {
                        int t = mass[i];
                        mass[i] = mass[j];
                        mass[j] = t;
                    }
                }
            }
            for (int i = 0; i < n; i++)
            { Console.WriteLine("{0}", mass[i]); }
            Console.ReadKey();
        }
    }
}
