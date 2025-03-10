namespace Task2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Длина в дюймах:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = 254;
            int c = (a * b) / 10000;
            int d = (a * b) % 10000/100;
            int e = (a * b) % 10000 % 100;
            Console.WriteLine("{0} дюйм(ов) = {1} м {2} см {3} мм",a,c,d,e );
            Console.ReadKey();
        }
    }
}
