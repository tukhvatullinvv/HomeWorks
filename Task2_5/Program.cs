namespace Task2_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine());
            a = Math.Ceiling(a);
            Console.WriteLine("{0}", a);
            Console.ReadKey();
        }
    }
}
