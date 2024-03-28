namespace task9_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FirstWord("Salam sagol"));
        }

        static string FirstWord(string word)
        {
            string first = "";
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == ' ')
                {
                    break;
                }
                first += word[i];
            }

            return first;   
        }
    }
}
