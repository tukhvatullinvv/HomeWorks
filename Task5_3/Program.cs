namespace Task5_3
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
                mass[i] = rnd.Next(0, 51);
                Console.WriteLine("{0}", mass[i]);
            }
            int max = mass[1];
            int min = mass[1];
            int iMax = 0;
            int iMin = 0;
            int j = 0;
            foreach (int i in mass)
            {
                j++;
                if (i > max)
                {
                    max = i;
                    iMax = j;
                }
                if (i < min)
                {
                    min = i;
                    iMin = j;
                }
            }
            Console.WriteLine("Макисмальное {0}({1}), Минимальное {2}({3})", max, iMax, min, iMin);
            Console.ReadKey();
        }
    }
}
