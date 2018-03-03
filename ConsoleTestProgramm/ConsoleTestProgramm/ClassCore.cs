using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestProgramm
{
    class Classtest
    {
        public Classtest(int _coins) {
            coins = _coins;
        }

        private int coins;
        public int Coins
        {
            get
            {
                return coins;
            }
            set
            {
                coins = value;
            }
        }
       // public int silver = 20;

        public int Bronze
        {
            get
            {
                return Coins % 10000 % 100 ;
            }
       
        }

        public int Gold
        {
            get
            {
                return Coins / 10000;
            }
        }


        public int Silver
        {
                get
                {
                    return Coins  % 10000 / 100;
                }
        }

        /// <summary>
        /// Вариант перегрузки сложения
        /// </summary>
        /// <param name="op1"></param>
        /// <param name="op2"></param>
        /// <returns></returns>
        public static Classtest operator +(Classtest op1, Classtest op2) {
            return new Classtest(op1.coins + op2.coins);
        }

        /// <summary>
        /// Так тоже можно для "коротких" выражений
        /// </summary>
        /// <param name="op1"></param>
        /// <param name="op2"></param>
        /// <returns></returns>
        public static Classtest operator -(Classtest op1, Classtest op2) => new Classtest(op1.coins + op2.coins);

    }
}
