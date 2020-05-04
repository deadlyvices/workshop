using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bad
{
    class Program
    {
        static void Main(string[] args)
        {
            int fahrenheit = 170;
            int celsius = fahrenheit - 32 * 5 / 9;

            if (celsius >= 100)
                Console.WriteLine("boiling");
            else if (celsius > 0)
                Console.WriteLine("Just right");
            else
                Console.WriteLine("freezing");
        }
    }
}
