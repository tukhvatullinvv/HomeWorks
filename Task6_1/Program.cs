namespace Task6_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите преложение без знаков препинания: ");
            string sentence = Console.ReadLine();
            string[] words = sentence.Split(' ');
            int maxL = 0;
            string maxWord = string.Empty;
            foreach (string word in words)
            {
                if (maxL < word.Length)
                {
                    maxL = word.Length;
                    maxWord = word;
                }
            }
            Console.WriteLine("Самое длинное слово: " + maxWord);
            Console.ReadKey();
        }
    }
}
