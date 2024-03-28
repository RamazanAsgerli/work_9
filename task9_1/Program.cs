namespace task9_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CleanSpace("salam,    jshs"));
        }

        static string CleanSpace(string word)
        {
            bool check = false;
            char space = ' ';
            string word1 = "";

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == space)
                {
                    check = true;
                }
                else
                {
                    if(check)
                    {
                        word1 += space;
                        check = false;
                    }
                  
                    word1 += word[i];
                }
            }
            return word1;
        }
    }
}
