using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestProgramm
{
    class Money
    {
        public Money(int _coins) {
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
        public static Money operator +(Money op1, Money op2) {
            return new Money(op1.coins + op2.coins);
        }

        /// <summary>
        /// Так тоже можно для "коротких" выражений
        /// </summary>
        /// <param name="op1"></param>
        /// <param name="op2"></param>
        /// <returns></returns>
        public static Money operator -(Money op1, Money op2) => new Money(op1.coins + op2.coins);

    }
}
