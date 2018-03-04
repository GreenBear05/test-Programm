using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestProgramm.Units
{
    class Army
    {
        private string NameArmy;


        public Army(string namearmy)
        {


            NameArmy = namearmy;
        }
        public string namearmy
        {
            get
            {
                return NameArmy;
            }
        }
        List<Unit> units = new List<Unit>();
        public List<Unit> Units
        {
            get
            {
                return units;
            }
            set
            {
                units = value;
            }
        }
    }
}
