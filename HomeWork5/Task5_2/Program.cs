namespace Task5_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            int[] mass = new int[n];
            Random rnd = new Random();
            int countPos = 0;
            int countNeg = 0;
            int countZero = 0;
            for (int i = 0; i < n; i++)
            {
                mass[i] = rnd.Next(-20, 21);
                Console.WriteLine("{0}", mass[i]);
                if (mass[i] > 0)
                { countPos++; }
                else
                {
                    if (mass[i] < 0)
                    { countNeg++; }
                    else { countZero++; }
                }
            }
            Console.WriteLine("Положительных {0}, Отрицательных {1}, Нолей {2}", countPos, countNeg, countZero);
            Console.ReadKey();
        }
    }
}
