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
            ClassConsoleReadLaine readLaine = new ClassConsoleReadLaine();
            int a = 1020123;
            cor.Bronze = readLaine.ReadLaine();

            Console.WriteLine("test vluve =  " + a);
            Console.WriteLine("cor.Bronze =  " + cor.Bronze);
            Console.WriteLine("cor.Silver =  " + cor.Silver);
            Console.WriteLine("cor.Gold =  " + cor.Gold);
            Console.ReadLine();
            Console.ReadLine();
        }
    }

}
