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
            //Warrior warrior = new Warrior(hp: 50);
            //Archer archer = new Archer(hp:50,name:"юнит");
            //warrior.Print();
            //archer.Print();

            List<Unit> Units = new List<Unit>();
            Units.Add(new Warrior(hp: 50));
            Units.Add(new Archer(hp: 50, name: "юнит"));

            foreach (var item in Units)
            {
                item.Print();
            }

            //Unit.Battle(archer, warrior, BattleField.Mountain);
            Console.ReadKey();
            

        }
    }
}
