using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Two_Number
{
    class Program
    {

       static public int[] TwoSum(int[] nums , int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target )
                    {
                        return new int[] { i, j };
                    }
                }
            }
            
            return new int[] {};
        }

        static void Main(string[] args)
        {

            int[] numbers = { 3, 2, 4, 6 };
            int[] results = TwoSum(numbers, 9);

            
            if (results.Length > 0)
            {
                Console.WriteLine("The indices of the numbers that sum to the target are: " + results[0] + " and " + results[1]);
            }
            else
            {
                Console.WriteLine("No two numbers sum up to the target.");
            }
        }
    }
}
