using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1
{
    class Program
    {

        static  void PrintHead()
        {

            Console.WriteLine("\t\t\t\tMultiplation Table\t\t\t\n");

            for(int i = 1; i <= 10; i++)
            {

                Console.Write("\t" + i );
            }

            Console.WriteLine("\n_____________________________________________________________________________________");

        }

        static string Colom(int i)
        {

            if (i < 10)

                return "   |";
            else
                return "  |";

        }

        static void PrintTable()
        {

            PrintHead();

            for(int i = 1; i <= 10; i++)
            {

                Console.Write(" " + i + Colom(i) + "\t");

                for(int j = 1; j <= 10; j++)
                {

                    Console.Write((i * j) + "\t");
                }

                Console.Write("\n");
            }


        }

        static void Main(string[] args)
        {

            PrintTable();
        }
    }
}
