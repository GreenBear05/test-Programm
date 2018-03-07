using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestProgramm.Units
{
    /// <summary>
    /// Класс аримя юнитов
    /// </summary>
    class Army
    {
       // private string NameArmy;

       
        public Army(string namearmy)
        {
            NameArmy = namearmy;
        }
        public string NameArmy { get; private set; }

        //  public string namearmy
        //  {
        //      get
        //      {
        //          return NameArmy;
        //      }
        //  }
        List<Unit> _Units = new List<Unit>();

        /// <summary>
        /// Добавление в аримю 
        /// </summary>
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
        /// <summary>
        /// Сражение армий
        /// </summary>
        /// <param name="army1">Первая армия</param>
        /// <param name="army2">Втроая армия</param>
        /// <param name="bf">Поле битвы</param>
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
