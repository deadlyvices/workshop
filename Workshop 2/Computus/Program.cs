using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computus
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = 0;
            const int M = 24, N = 5;
            string response = "";
            do
            {
                Console.Write("Enter the year:");
                response = Console.ReadLine();
                if (int.TryParse(response, out year))
                {
                    int a = year % 19;
                    int b = year % 4;
                    int c = a % 7;
                    int d = (19 * a + M) % 30;
                    int e = (2 * b + 4 * c + 6 * d + N) % 7;
                    if (d + e < 10)
                    {
                        Console.WriteLine("Easter falls on March {0} ", (d + e + 22));
                    }
                    else
                    {
                        int date = d + e - 9;
                        if (date == 26)
                        {
                            date = 19;
                        }
                        else if (date == 25 & d == 28 & e == 6 & a > 10)
                        {
                            date = 18;
                        }
                        Console.WriteLine("Easter falls on April {0} ", date);
                    }
                }
            } while (response != "");
        }
    }
}
