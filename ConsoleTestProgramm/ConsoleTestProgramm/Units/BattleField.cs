using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleTestProgramm.Units
{
    /// <summary>
    /// тип поля боя
    /// </summary>
    public enum BattleField // множество
    {
        /// <summary>
        /// Открытое поле
        /// Бонус у дальнего боя
        /// </summary>
        Field,
        /// <summary>
        /// Лес
        /// Бонус у ближнего боя
        /// </summary>
        Forest,
        /// <summary>
        /// Снежная равнина 
        /// Нет бонуса
        /// </summary>
        Snou,
        /// <summary>
        /// горная месность 
        /// отрицательный бонус атака -%10
        /// </summary>
        Mountain
    }
}
