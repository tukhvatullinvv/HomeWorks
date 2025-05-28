namespace Task5_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            int[] mass = new int[n];
            Random rnd = new Random();
            int countEven = 0;
            for (int i = 0; i < n; i++)
            {
                mass[i] = rnd.Next(0, 101);
                Console.WriteLine("{0}", mass[i]);
                if (mass[i] % 2 == 0)
                { countEven++; }
            }
            if ((n / countEven) < 2)
            {
                Console.WriteLine("Четных больше");
            }
            else
            {
                if ((n / countEven) == 2)
                    Console.WriteLine("Четных и нечетных поровну");
                else
                {
                    Console.WriteLine("Нечетных больше");
                }
            }
            Console.ReadKey();
        }
    }
}
