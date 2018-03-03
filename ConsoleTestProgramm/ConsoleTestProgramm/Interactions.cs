using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestProgramm
{
    public static class Interactions
    {
        static public int ReadLaine(string msg)
        {
            Console.Write(msg + "  >  ");
            string x;
            x = Console.ReadLine();
            return Convert.ToInt32(x);
        }
    }
}
