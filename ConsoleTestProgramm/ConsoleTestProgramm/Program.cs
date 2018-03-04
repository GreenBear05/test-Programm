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
            //  Warrior warrior = new Warrior(hp: 50, name: "Romic");
            //  Archer archer = new Archer(hp: 50, name: "Igor");
            //  Console.ForegroundColor = ConsoleColor.Green; // устанавливаем цвет
            //  Console.WriteLine("...");
            //  warrior.Print();
            //  archer.Print();
            //  Unit.Battle(archer, warrior, BattleField.Mountain);
            //  Console.ReadKey();
            Army army1 = new Army();
            army1.Units.Add(new Warrior(hp: 50, name: "Romic"));

            List<Unit> Units = new List<Unit>();
            Units.Add(new Warrior(hp: 50, name: "Romic"));
            Units.Add(new Archer(hp: 50, name: "sergyi"));
            Units.Add(new Warrior(hp: 50, name: "vasay"));
            Units.Add(new Archer(hp: 150, name: "Igor"));

            foreach (var item in army1.Units)
            {
                item.Print();
            }
            int i =1;
            foreach (var item in Units)
            {
                i++;
                Unit.Battle(item, item, BattleField.Mountain);
            }
          // Money moneyshops = new Money(5646);
          // Money moneyucer = new Money(444651);
          // Console.WriteLine(moneyucer.Coins + "   " + moneyucer.Bronze + "   " + moneyucer.Silver + "   " + moneyucer.Gold);
          // Console.WriteLine(moneyshops.Coins + "   " + moneyshops.Bronze + "   " + moneyshops.Silver + "   " + moneyshops.Gold);
          // moneyucer -= moneyshops;
          //
          // Console.WriteLine(moneyucer.Coins +"   "+ moneyucer.Bronze +"   "+ moneyucer.Silver +"   "+moneyucer.Gold);
          // Console.WriteLine(moneyshops.Coins + "   " + moneyshops.Bronze + "   " + moneyshops.Silver + "   " + moneyshops.Gold);
          // Console.ReadKey();

        }
    }
}
