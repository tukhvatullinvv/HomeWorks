namespace Task4_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число в диапазоне [20;60]");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a < 20 || a > 60)
                while (a < 20 || a > 60)
                {
                    Console.WriteLine("Число должно быть в диапазоне [20;60]");
                    a = Convert.ToInt32(Console.ReadLine());
                }
            Console.ReadLine();
        }
    }
}
