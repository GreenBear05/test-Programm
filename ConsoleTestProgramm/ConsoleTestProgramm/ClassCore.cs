using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestProgramm
{
    class Classtest
    {
        private int coints;
        public int Coints
        {
            get
            {
                return coints;
            }
            set
            {
                coints = value;
            }
        }
       // public int silver = 20;

        public int Bronze
        {
            get
            {
                return Coints % 10000 % 100 ;
            }
       
        }

        public int Gold
        {
            get
            {
                return Coints / 10000;
            }
        }


        public int Silver
        {
                get
                {
                    return Coints  % 10000 / 100;
                }
        }


    }
}
