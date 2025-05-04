namespace Task3_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Габариты участка:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int length = Math.Max(a, b);
            int width = Math.Min(a, b);
            Console.WriteLine("Габариты дома 1:");
            int p = Convert.ToInt32(Console.ReadLine());
            int q = Convert.ToInt32(Console.ReadLine());
            int length1 = Math.Max(p, q);
            int width1 = Math.Min(p, q);
            Console.WriteLine("Габариты дома 2:");
            int r = Convert.ToInt32(Console.ReadLine());
            int s = Convert.ToInt32(Console.ReadLine());
            int length2 = Math.Max(r, s);
            int width2 = Math.Min(r, s);
            if (length < (length1 + length2) || (width < width1) || (width < width2))
            {
                Console.WriteLine("Дома не помещаются на участке");
            }
            else
            {
                Console.WriteLine("Дома можно разместить на участке");
            }
            Console.ReadKey();
        }
    }
}
