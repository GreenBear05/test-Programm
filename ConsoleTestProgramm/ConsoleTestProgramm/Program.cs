using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleTestProgramm.Units;

namespace ConsoleTestProgramm
{
    class Program
    {
        static void Main(string[] args)
        {
            Warrior warrior = new Warrior(hp: 50,name: "Romic");
            Archer archer = new Archer(hp:50,name:"Igor");
            warrior.Print();
            archer.Print();
            Unit.Battle(archer, warrior, BattleField.Mountain);
            Console.ReadKey();
            

        }
    }
}
