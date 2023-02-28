using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace testConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //            decimal x =
            //Decimal.Divide((20 + 20 + 20 + 40 + 40 + 15 + 30 + 60 + 20 + 20 + 10 + 00 + 00 + 25 + 35 + 00 + 05 + 05 + 25 + 20),
            //               (20 + 20 + 20 + 40 + 40 + 15 + 30 + 60 + 20 + 20 + 10 + 05 + 25 + 25 + 35 + 05 + 05 + 05 + 25 + 20));
            //            WriteLine(x);

            int x = 4;
            int y = 5;
            if (y == x++)
                Write("u");
            Write(x + " " + y);
            ReadKey();
            Class1 c = new Class1();
            Class1 c2 = new Class1(2);

        }
    }
}
