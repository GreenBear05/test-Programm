using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestProgramm.Units
{
    class Army
    {
       // private string NameArmy;

        public string NameArmy { get; private set; }
        public Army(string namearmy)
        {
            NameArmy = namearmy;
        }
      //  public string namearmy
      //  {
      //      get
      //      {
      //          return NameArmy;
      //      }
      //  }
        List<Unit> _Units = new List<Unit>();
        public List<Unit> Units
        {
            get
            {
                return _Units;
            }
            set
            {
                _Units = value;
            }
     
        }

        //  public Unit this[int index]
        //  {
        //      get
        //      {
        //          return _Units[index];
        //      }
        //  }
        //  public void Add(Unit unit)
        //  {
        //      _Units.Add(unit);
        //  }

        public static void Battle(Army army1, Army army2, BattleField bf)
        {
            
            Interactions.WriteLine(army1.NameArmy+"    vs    "+army2.NameArmy);
            int i = 0, j = 0;
            while (i < army1._Units.Count && j < army2._Units.Count)
            {
                
                Unit.Battle(army1._Units[i], army2._Units[j], bf);
                if (!army1._Units[i].IsAlive)
                    i++;

                if (!army2._Units[j].IsAlive)
                    j++;
            }

            if (i == army1._Units.Count)
                Console.WriteLine("Армия " + army1.NameArmy + " повержена.");
            if (j == army2._Units.Count)
                Console.WriteLine("Армия " + army2.NameArmy + " повержена.");
        }

    }
}
