using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestProgramm.Units
{
    class Archer : Unit
    {
        public Archer(float attack = 10, float hp = 5,string name ="uint Archr"):base (hp,name)
        {
            DistanceAttack = attack; 
        }
    }
}
