namespace Task5_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int s = 10;
            const int c = s / 2;
            int[,] mass = new int[s, c];
            Random rnd = new Random();
            for (int i = 0; i < s; i++)
            {
                int max = 0;
                int index = 1;
                for (int j = 0; j < c; j++)
                {
                    mass[i, j] = rnd.Next(0, 11);
                    Console.Write("{0} ", mass[i, j]);
                    if (mass[i, j] > max)
                    {
                        max = mass[i, j];
                        index += j;
                    }
                }
                Console.Write(" max={0}({1})", max, index);
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
