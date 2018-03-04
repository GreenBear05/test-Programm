using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestProgramm.Units
{
    class Army
    {
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
