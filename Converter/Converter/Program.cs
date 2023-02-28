using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            string num;
            WriteLine("enter decimal n1:");
            num = (ReadLine());
            int n = 0;
            n = int.Parse(num);
            Binary b = new Binary(n);
            WriteLine("binary b1 = " + b + "\n");

            string num2;
            WriteLine("enter decimal n2:");
            num2 = (ReadLine());
            int n2 = 0;
            n2 = int.Parse(num2);
            Binary b2 = new Binary(n2);
            WriteLine("binary b2 = " + b2 + "\n");

            WriteLine("b1 + b2 = " + b.Add(b2));
            WriteLine("b1 and b2 = " + b.And(b2));
            WriteLine("b1 or b2 = " + b.Or(b2));
            WriteLine("not b1 = " + b.Not());
            WriteLine("b1 shift left = " + b.ShiftLeft());

            ReadKey();

            //BinaryConverter b = new BinaryConverter(num);
            //WriteLine(b.ToDecimal());
            //WriteLine(b.ToOctal());

            //DecimalConverter d = new DecimalConverter(n);
            //WriteLine(d.ToBinary());
        }
    }
}
