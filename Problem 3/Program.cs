using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3
{
    class Program
    {

        static string LongestCommonPrefix(string[] strs)
        {

            if (strs.Length == 0)
                return "";

            if (strs.Length == 1)
                return strs[0];

            string prefix = strs[0];


            for(int i = 1; i < strs.Length; i++)
            {

                int j = 0;
                while (j < prefix.Length && j < strs[i].Length && prefix[j] == strs[i][j])
                {
                    j++; 
                }

                
                prefix = prefix.Substring(0, j);

                
                if (prefix == "")
                    return "";
            }

            return prefix;
        }


        static void Main(string[] args)
        {

            string[] strsTest1 = { "flower", "flow", "flight" }; // This case we return "fl" as Commonprefix;
            string[] strsTest2 = { "dog", "racecar", "car" }; // This case we return empty string;

            Console.WriteLine(LongestCommonPrefix(strsTest1));
            Console.WriteLine(LongestCommonPrefix(strsTest2));

        }
    }
}
