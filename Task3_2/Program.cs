using System.Runtime.Serialization;

namespace Task3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int max = a;
            if (b > max)
            {
                max = b;
            }
            if (c > max)
            {
                max = c;
            }
            Console.WriteLine("Максимальное число:{0}",max);
            Console.ReadKey();
        }
    }
}
