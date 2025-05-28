namespace Task4_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число a");
            int a = Convert.ToInt32(Console.ReadLine());
            while (a < 0)
            {
                Console.WriteLine("a должно быть больше 0");
                a = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Введите число b");
            int b = Convert.ToInt32(Console.ReadLine());
            while (b > 0)
            {
                Console.WriteLine("b должно быть меньше 0");
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
            }
            double c = 1;
            for (int i = 1; i <= (b * (-1)); i++)
            {
                c = c * a;
            }
            Console.WriteLine("{0}", 1 / c);
            Console.ReadKey();
        }
    }
}
