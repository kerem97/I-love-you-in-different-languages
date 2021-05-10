using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("     Languages     ");
            Console.WriteLine("  1-   Turkish     ");
            Console.WriteLine("  2-   English     ");
            Console.WriteLine("  3-   Deutsch     ");
            Console.WriteLine("  4-   French     ");
            Console.Write("     Please choose  :   ");
            int sec = int.Parse(Console.ReadLine());
            Console.WriteLine();
            switch (sec)
            {
                case 1: Console.WriteLine("     Seni Seviyorum     ");
                    break;
                case 2:
                    Console.WriteLine("     I Love You     ");
                    break;
                case 3:
                    Console.WriteLine("     Ich Liebe Dich     ");
                    break;
                case 4:
                    Console.WriteLine("    Je t'aime     ");
                    break;
                default:Console.WriteLine("Wrong choice");
                    break;
            }
            Console.ReadKey();


        }
    }
}
