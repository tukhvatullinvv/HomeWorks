namespace Task4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int k = 1;
            for (int i = 1; i <= a; i++)
            {
                k = k * i;
            }
            Console.WriteLine("{0}", k);
            Console.ReadKey();
        }
    }
}
