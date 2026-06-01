namespace Task6_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите предложение: ");
            string input = Console.ReadLine() ?? string.Empty;

            string normalized = new string(
                input
                    .Where(c => c != ' ')
                    .Select(char.ToLowerInvariant)
                    .ToArray());

            bool isPalindrome = true;

            for (int i = 0, j = normalized.Length - 1; i < j; i++, j--)
            {
                if (normalized[i] != normalized[j])
                {
                    isPalindrome = false;
                    break;
                }
            }

            Console.WriteLine(isPalindrome ? "Строка является палиндромом." : "Строка не является палиндромом.");
        }
    }
}
