namespace Task5_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 5;
            int[,] mass = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if ((i + j) % 2 == 0)
                        mass[i, j] = 1;
                    Console.Write("{0} ", mass[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
