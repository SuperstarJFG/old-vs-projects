using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace FinalMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix m = new Matrix(1, 1, 1, 1);
            Matrix m2 = new Matrix(1, 2, 3, 4);
            WriteLine(m); WriteLine(" + ");
            WriteLine(m2);
            WriteLine(" = ");
            WriteLine(m.add(m2));
            WriteLine();
            WriteLine(2);
            WriteLine(" * ");
            WriteLine(m2);
            WriteLine(" = ");
            WriteLine(m2.scalarMultiply(2));
            ReadKey();
        }
    }
}
