namespace Task6_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Месяц: ");
            string month = Console.ReadLine();
            Console.Write("Год: ");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.Write("Общая сумма продаж: ");
            double summ = Convert.ToDouble(Console.ReadLine());
            Console.Write("Количество проданных товаров: ");
            int items = Convert.ToInt32(Console.ReadLine());
            double average = items > 0 ? summ / items : 0;
            string summFormat = String.Format("{0:N2}", summ);
            string itemsFormat = String.Format("{0:N0}", items);
            string averageFormat = String.Format("{0:N2}", average);
            Console.WriteLine("--------------------------------");
            Console.WriteLine($"Отчёт о продажах за {month} {year} г.");
            Console.WriteLine("--------------------------------");
            Console.WriteLine($"Общая сумма продаж: {summFormat} р.");
            Console.WriteLine($"Количество проданных товаров: {itemsFormat} шт.");
            Console.WriteLine($"Средняя стоимость товара: {averageFormat} р.");
            Console.ReadKey();
        }
    }
}
