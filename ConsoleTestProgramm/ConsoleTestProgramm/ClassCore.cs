using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestProgramm
{
    class ClassCore
    {
        private int coints = 10 ;

        public int silver = 20;

        public int Bronze
        {
            get
            {
                return coints /*% 1000 % 100 / 1*/;
            }
            set
            {
                coints = value;
            }
        }

        public int Gold
        {
            get
            {
                return Bronze / 1000;
            }
        }


        public int Silver
        {
                get
                {
                    return Bronze  % 1000 / 10;
                }
        }


    }
}
