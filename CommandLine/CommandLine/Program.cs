using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.IO;

namespace CommandLine
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Enter command, Press ENTER to QUIT");
            string line = ReadLine();
            string cmd = line;
            string arg = "";
            if (line.IndexOf(" ") > 0)
            {
                arg = line.Substring(line.IndexOf(" ") + 1);
                cmd = line.Substring(0, line.IndexOf(" "));
            }
            while (cmd != "")
            {
                // WriteLine(cmd);
                switch (cmd.ToLower())
                {
                    case "pwd":
                        WriteLine(Directory.GetCurrentDirectory());
                        break;
                    case "cd":
                        //Directory.SetCurrentDirectory(@"c:\");
                        if (arg.Length > 0)
                            Directory.SetCurrentDirectory(arg);
                        WriteLine(Directory.GetCurrentDirectory());
                        break;
                    case "ls":
                        if (arg = d)
                            Directory.GetFiles(Directory.GetCurrentDirectory());
                        break;
                    default:
                        break;
                }
                arg = "";
                line = ReadLine();
                if (line.IndexOf(" ") > 0)
                {
                    arg = line.Substring(line.IndexOf(" ") + 1);
                    cmd = line.Substring(0, line.IndexOf(" "));
                }
            }
        }
    }
}
