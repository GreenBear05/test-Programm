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

           
            Money sl1 = new Money(Interactions.ReadLaine());
            Money sl2 = new Money(Interactions.ReadLaine());
            sl1 = sl1 + sl2;
           // Classtestt1 cortest1 = new Classtestt1();
           // Classtestt2 cortest2 = new Classtestt2();
           // int a = 1020123;
          // cortest1.Coints = readLaine.ReadLaine();
          // cortest2.Coints = readLaine.ReadLaine();
          //

           // Console.WriteLine("test vluve =  " + sl1.Coints);
            Console.WriteLine("cor.Bronze =  " + sl1.Bronze);
            Console.WriteLine("cor.Silver =  " + sl1.Silver);
            Console.WriteLine("cor.Gold =  " + sl1.Gold);
            Console.ReadLine();
            Console.ReadLine();
        }
    }
}
