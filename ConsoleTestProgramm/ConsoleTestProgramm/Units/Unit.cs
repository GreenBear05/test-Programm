using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestProgramm.Units
{
    class Unit
    {
        protected Unit(float hp,string name)
        {
            
            HP = hp;
            Name = name;
        }
        private float HP;

        private string Name;
        /// <summary>
        ///  MeleeAttack - для ближнего боя
        /// </summary>
        protected float MeleeAttack;
        /// <summary>
        ///  DistanceAttack для дальнего боя
        /// </summary>
        protected float DistanceAttack;
        public void Print()
        {
            Console.WriteLine("Unit  :"+HP + " : " + MeleeAttack +"/"+ DistanceAttack);
        }
        
        public static void Battle(Unit unit1,Unit unit2,BattleField bf)
        {
            float unit1attack;
            float unit2attack;
            switch (bf)
            {
                case BattleField.Field:
                    Console.WriteLine(" Бой поле ");
                    unit1attack = unit1.MeleeAttack + unit1.DistanceAttack * 1.5f;
                    unit2attack = unit2.DistanceAttack * 1.5f + unit2.MeleeAttack;
                    break;
                case BattleField.Forest:
                    Console.WriteLine(" Бой лес");
                    unit1attack = unit1.MeleeAttack * 1.5f + unit1.DistanceAttack ;
                    unit2attack = unit2.DistanceAttack  + unit2.MeleeAttack * 1.5f;
                    break;
                case BattleField.Snou:
                    Console.WriteLine(" Бой снежная равнина");
                    unit1attack = unit1.MeleeAttack + unit1.DistanceAttack;
                    unit2attack = unit2.DistanceAttack + unit2.MeleeAttack;
                    break;
                case BattleField.Mountain:
                    Console.WriteLine(" Бой горная месность ");
                    
                    unit1attack = unit1.MeleeAttack*0.9f + unit1.DistanceAttack;
                    unit2attack = unit2.DistanceAttack + unit2.MeleeAttack * 0.9f;
                    break;
                default:
                    Console.WriteLine(" Бой ");
                    unit1attack = unit1.MeleeAttack + unit1.DistanceAttack;
                    unit2attack = unit2.DistanceAttack + unit2.MeleeAttack;
                    break;
            }
            
            while (unit1.HP > 0 && unit2.HP > 0)
            {
                unit1.HP -= unit2attack;
                Console.WriteLine("Удар по "+ unit1.Name + "  " + unit1.HP+"  урон по юниту 1  - "+unit2attack+"\n");
                unit2.HP -= unit1attack;
                Console.WriteLine("Удар по " + unit2.Name + "  " + unit2.HP + "  урон по юниту 2  - " + unit1attack + "\n");
            }
        }
    }
}
