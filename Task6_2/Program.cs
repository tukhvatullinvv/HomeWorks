namespace Task6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите преложение без знаков препинания: ");
            string sentence = Console.ReadLine().ToLower().Replace(" ", "");
            int l = sentence.Length;
            bool f = true;
            for (int i = 0; i < l; i++)
            {
                if (sentence[i] != sentence[l - i - 1])
                {
                    f = false;
                    break;
                }
            }
            if (f)
            {
                Console.WriteLine("Является палиндромом");
            }
            else
            {
                Console.WriteLine("Не является палиндромом");
            }
            Console.ReadKey();
        }
    }
}
