 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_7
{
    class Program
    {

       static public int SingleNumber(int[] nums)
        {

            int results = 0; 

            for(int i = 0; i < nums.Length; i++)
            {

                results = results ^ nums[i];
            }

            return results;
        }


        static void Main(string[] args)
        {

            int[] arr = { 3, 1, 1 };

            Console.WriteLine("The Single Numbe in this array is : " + SingleNumber(arr));

        }
    }
}
