namespace task9_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Word("12aA"));
        }

        static bool Word(string word)
        {
            int count = 0;
            int count1 = 0;
            int count2 = 0;
            bool check = true;
             for (int i = 0; i < word.Length; i++)
            {
                if (word[i] >= 65 && word[i] <= 90)
                {
                    count++;
                }
               else if (word[i] >= 97 && word[i] <= 122)
                {
                    count1++;
                }
               
               else if (word[i] >= 48 && word[i] <= 57)
                {
                    count2++;
                }
                else
                {
                    check = false;
                    break;
                }
               
            }
            if (count >= 1 && count1 >= 1 && count2 >= 1)
            {
                check = true;
            }
            else
            {
                check = false;
            }
            return check;
        }
    }
}
