using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestProgramm.Units
{
    /// <summary>
    /// Класс юнит 
    /// </summary>
    class Unit
    {
        protected Unit(float HP,string name)
        {
            _HP = HP;
            Name = name;
        }
        private float _HP;

        private string Name;
        /// <summary>
        ///  MeleeAttack - для ближнего боя
        /// </summary>
        protected float MeleeAttack;
        /// <summary>
        ///  DistanceAttack для дальнего боя
        /// </summary>
        protected float DistanceAttack;
        /// <summary>
        /// Вывод данных о сзданнных юнитах
        /// </summary>
        public void Print()
        {
            //   Console.WriteLine(this.Name + " [HP: " + HP + " : " + MeleeAttack + "/" + DistanceAttack + "]");
            Interactions.Write(this.Name + " [HP: ");
            Interactions.Write(_HP.ToString(),ConsoleColor.Red);
            Interactions.Write(" : " + MeleeAttack + "/" + DistanceAttack + "]\n");

        }
        /// <summary>
        /// Сражение меду 2 юнитами
        /// </summary>
        /// <param name="unit1">первый юнит</param>
        /// <param name="unit2">Второй юнит</param>
        /// <param name="bf">Тип пля</param>
        public static void Battle(Unit unit1, Unit unit2, BattleField bf)
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
                    unit1attack = unit1.MeleeAttack * 1.5f + unit1.DistanceAttack;
                    unit2attack = unit2.DistanceAttack + unit2.MeleeAttack * 1.5f;
                    break;
                case BattleField.Snou:
                    Console.WriteLine(" Бой снежная равнина");
                    unit1attack = unit1.MeleeAttack + unit1.DistanceAttack;
                    unit2attack = unit2.DistanceAttack + unit2.MeleeAttack;
                    break;
                case BattleField.Mountain:
                    Console.WriteLine(" Бой горная месность ");

                    unit1attack = unit1.MeleeAttack * 0.9f + unit1.DistanceAttack;
                    unit2attack = unit2.DistanceAttack + unit2.MeleeAttack * 0.9f;
                    break;
                default:
                    Console.WriteLine(" Бой ");
                    unit1attack = unit1.MeleeAttack + unit1.DistanceAttack;
                    unit2attack = unit2.DistanceAttack + unit2.MeleeAttack;
                    break;
            }

            while (unit1._HP > 0 && unit2._HP > 0)
            {
                System.Threading.Thread.Sleep(1000);
                unit1._HP -= unit2attack;
                Interactions.WriteMacroLine("Удар по _","f:green",unit1.Name,"def","_  " ,"f:red", unit1._HP.ToString() ,"def", "  урон от _" , "f:green", unit2.Name, "def", "_   Сила атаки  " , "f:blue", unit2attack.ToString(),  "def");
                unit2._HP -= unit1attack;
                Interactions.WriteMacroLine("Удар по _", "f:green", unit2.Name, "def", "_  ", "f:red", unit2._HP.ToString(), "def", "  урон от _", "f:green", unit1.Name, "def", "_   Сила атаки  ", "f:blue", unit1attack.ToString(), "def","\n");
            }
            if(!unit1.IsAlive)
            {
                Interactions.WriteLine(unit1.Name+"  мертв");
            }
            if (!unit2.IsAlive)
            {
                Interactions.WriteLine(unit2.Name+"  мертв");
            }
        }
        /// <summary>
        /// проверка метв или юнит
        /// </summary>
            public bool IsAlive
        {
            get
            {
                return _HP > 0;
            }
        }
    }
    
}
