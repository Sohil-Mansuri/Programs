using System;

namespace TwoSumArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new[] { 2, 7, 11, 15 };

            var result = TwoSum(nums, 9);

            for (int i = 0; i < result.Length; i++)
            {
                Console.Write($"{result[i]}, ");
            }
           
            Console.ReadKey();
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            for (int numIndex = 0; numIndex < nums.Length; numIndex++)
            {
                for (int numSecondIndex = numIndex + 1; numSecondIndex < nums.Length; numSecondIndex++)
                {
                    if (nums[numIndex] + nums[numSecondIndex] == target)
                        return new int[] { numIndex, numSecondIndex };
                }
            }

            return null;
        }
    }
}
