using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Valide_Number
{
    class Program
    {

        static public bool IsPalidrom(string s)
        {

            int startS = 0;
            int endS = s.Length - 1;

            while (startS < endS)
            {

                if (!char.IsLetterOrDigit(s[startS]))

                    startS++;
                else if (!char.IsLetterOrDigit(s[endS]))

                    endS--;

                else if (char.ToLower(s[startS]) != char.ToLower(s[endS]))
                {

                    return false;
                }

                else
                {

                    startS++;
                    endS--;

                }
            }


            return true;
        }

        static void Main(string[] args)
        {



            if (IsPalidrom("raceacar"))
            {

                Console.WriteLine("Yes Is Palidrome string");
            }
            else
            {

                Console.WriteLine("No is Not A Palidrome string");

            }

        }

    }
}
