using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace asynchronousInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            water w = new water();
            WriteLine(w.fill());
            WriteLine(w.waterPlants());
            WriteLine(w.spill());
            ReadKey();
        }
    }
    class liquid
    {
        public string fill()
        {
            return "filled up";
        }
        public string spill()
        {
            return "sploosh";
        }
    }
    class water : liquid
    {
        public string waterPlants()
        {
            return "the plants are watered yay";
        }
    }
}
