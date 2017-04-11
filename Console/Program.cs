using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathLibNET;
using StringLibNET;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine(StringLib.getStringLength("ahoj"));

            StringBuilder s = new StringBuilder("  a h oj  ");
            StringLib.trim(s);

            System.Console.WriteLine(StringLib.getVersionInfo());
            System.Console.WriteLine(s);

            System.Console.ReadLine();
        }
    }
}
