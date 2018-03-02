using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestProgramm
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassCore cor = new ClassCore();
            String a = Convert.ToString(cor.silver);
              Console.WriteLine(a);
           Console.WriteLine(cor.Silver);
            Console.ReadLine();
        }
    }

}
