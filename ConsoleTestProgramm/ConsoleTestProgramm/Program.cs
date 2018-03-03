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
            Classtest cortest1 = new Classtest();
            Classtest2 cortest2 = new Classtest2();
            ClassConsoleReadLaine readLaine = new ClassConsoleReadLaine();
            int a = 1020123;
            cortest1.Coints = readLaine.ReadLaine();
            cortest2.Coints = readLaine.ReadLaine();


            Console.WriteLine("test vluve =  " + cortest2.Coints);
            Console.WriteLine("cor.Bronze =  " + cortest1.Bronze);
            Console.WriteLine("cor.Silver =  " + cortest1.Silver);
            Console.WriteLine("cor.Gold =  " + cortest1.Gold);
            Console.ReadLine();
            Console.ReadLine();
        }
    }

}
