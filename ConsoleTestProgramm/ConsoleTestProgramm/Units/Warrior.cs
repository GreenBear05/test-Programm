using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestProgramm.Units
{
    class Warrior : Unit
    {
        public Warrior(float attack = 5,float hp = 5,string name = "uint Warrior") : base(hp, name)
        {
            MeleeAttack = attack;
        }

    }
}
