using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2
{

    class Remove
    {

        static int RemoveDuplication(int[] nums)
        {

            int count = 1;

            if (nums.Length == 0)
                return 0;

            for (int i = 1; i < nums.Length; i++)
            {

                if (nums[i] != nums[i - 1])
                {
                    nums[count] = nums[i];
                    count++;
                }
            }

            return count;


        }


        static void Main(string[] args)
        {


            int[] nums = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };

           

            Console.WriteLine(RemoveDuplication(nums));


        }
    }


}
