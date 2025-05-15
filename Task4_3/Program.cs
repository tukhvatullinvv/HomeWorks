namespace Task4_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа a и b");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            if (a < 0 || b < 0)
                while (a < 0 || b < 0)
                {
                    Console.WriteLine("Оба числа должны быть больше 0");
                    a = Convert.ToInt32(Console.ReadLine());
                    b = Convert.ToInt32(Console.ReadLine());
                }
            int c = 1;
            for (int i = 1; i <= b; i++)
            {
                c = c * a;
            }
            Console.WriteLine("{0}", c);
            Console.ReadKey();
        }
    }
}
