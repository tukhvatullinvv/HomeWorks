namespace Task3_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            if (a % 10 == 1)
            {
                Console.WriteLine("Мы построили {0} дом", a);
            }
            else
            {
                if (a % 10 >= 2 && a % 10 < 5)
                {
                    Console.WriteLine("Мы построили {0} дома", a);
                }
                else
                {
                    Console.WriteLine("Мы построили {0} домов", a);
                }
            }
            Console.ReadKey();
        }
    }
}
