namespace task9_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Words("Salam  Dunya"));
        }

        static bool Words(string words) 
        {

         int count = 0;
         bool check = true;

            if (words[0] >= 65 && words[0] <= 90)
            {
                count++;
            }

            for (int i = 0; i < words.Length; i++)
            {
               
               if (words[i] == ' ' && words[i+1] != ' ')
               { 
                     if (words[i+1] >= 65 && words[i + 1] <= 90)
                     {
                        count++;
                     }
                    else
                    {
                       check = false;
                    }
               }
               if (count == 2)
                {
                    check = true;
                }
                else
                {
                    check = false;
                }
                    
            }
          return check;
        }
    }
}
