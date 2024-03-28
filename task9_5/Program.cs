namespace task9_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] b = { 1, 2, 3, 4, 5 };
            int a = 6;
            Nums(b,a);
        }
        static void Nums (int[] num,int n)
        {
             int[] nums = new int[num.Length+1];
             for(int i = 0; i < num.Length; i++)
            {
                nums[i] = num[i];
            }
            nums[nums.Length-1] = n;
            num = nums;
            
            for(int i = 0;i < num.Length;i++)
            {
                Console.WriteLine(nums[i]);
            }
        }
    }
}
