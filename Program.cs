using System;

namespace TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 3, 6, 2, 9, 4, 10, -2 };
            Console.WriteLine(TwoSum(numbers, 6));
        }
        static bool TwoSum(int[] numbers, int target)
        {
            bool sumIsTarget = false;
            for(int i = 0; i < numbers.Length; i++)
            {
                for(int j = i + 1; j < numbers.Length; j++)
                {
                    if(numbers[i] + numbers[j] == target)
                    {
                        sumIsTarget = true;
                    }
                }
            }
            return sumIsTarget;
        }
    }
}
