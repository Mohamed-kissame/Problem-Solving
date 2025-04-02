using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4
{
    class Program
    {

       static int LengthOfLastWord(string s)
        {
            int length = 0;

            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] != ' ')
                {

                    length++;

                }


                else if (length > 0)
                {
                    break;
                }
            }

            return length;
        }
        
        static void Main(string[] args)
        {

            Console.WriteLine(LengthOfLastWord("Hello World")); // in this case will be return length = 5 ;
            Console.WriteLine(LengthOfLastWord("Mohamed Kissame")); // in this case will be return length = 7 ;
            Console.WriteLine(LengthOfLastWord("Casablanca")); // in this case will be return length = 10 ;

            // so this all test Case is correct; 
            // In this code this method will be find the space elemenet and start to count the length ;
        }
    }
}
