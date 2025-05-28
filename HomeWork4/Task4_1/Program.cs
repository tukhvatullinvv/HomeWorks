namespace Task4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long a = Convert.ToInt32(Console.ReadLine());
            while (a >= 21 || a < 0)
            {
                Console.WriteLine("Вычислить факториал не получится. Введите натуральное число до 21");
                a = Convert.ToInt32(Console.ReadLine());
            }
            long k = 1;
            for (int i = 1; i <= a; i++)
            {
                k *= i;
            }
            Console.WriteLine("{0}", k);
            Console.ReadKey();
        }
    }
}