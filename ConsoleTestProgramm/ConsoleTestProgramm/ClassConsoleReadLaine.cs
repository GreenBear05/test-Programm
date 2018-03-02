using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestProgramm
{
    class ClassConsoleReadLaine
    {
        public int ReadLaine()
        {
            string x;
            x = Console.ReadLine() ;
            return Convert.ToInt32(x);
        }
    }
}
