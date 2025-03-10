namespace Task2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите угол в градусах, минутах, секундах");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int e = (a * 3600 + b * 60 + c) / 3600/360*360;
            double d = ((a + b / 60.0 + c / 3600.0) - ((a * 3600 + b * 60 + c) / 3600)/360*360) * Math.PI / 180.0;
            Console.WriteLine("Угол в радианах={0},{1}" ,d, e);
            Console.ReadKey();
        }
    }
}

