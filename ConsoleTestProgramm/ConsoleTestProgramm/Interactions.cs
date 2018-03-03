using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestProgramm
{
    public static class Interactions
    {
        static public int ReadLaine(string msg)
        {
            Console.Write(msg + "  >  ");
            string x;
            x = Console.ReadLine();
            return Convert.ToInt32(x);
        }
        /// <summary>
        /// //[0]                                
        /// //Black System.ConsoleColor
        /// //[1] DarkBlue System.ConsoleColor
        /// //[2] DarkGreen   System.ConsoleColor
        /// //[3] DarkCyan    System.ConsoleColor
        /// //[4] DarkRed System.ConsoleColor
        /// //[5] DarkMagenta System.ConsoleColor
        /// //[6] DarkYellow  System.ConsoleColor
        /// //[7] Gray    System.ConsoleColor
        /// //[8] DarkGray    System.ConsoleColor
        /// //[9] Blue    System.ConsoleColor
        /// //[10] Green   System.ConsoleColor
        /// //[11] Cyan    System.ConsoleColor
        /// //[12] Red System.ConsoleColor
        /// //[13] Magenta System.ConsoleColor
        /// //[14] Yellow  System.ConsoleColor
        /// //[15] White   System.ConsoleColor
        /// </summary>
        static public void colorWriteLine()
        {
            ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
                Console.ForegroundColor = colors[5];
                Console.Write("   The foreground color is {0}.", colors[7]);
            
        }
        ////        Get an array with the values of ConsoleColor enumeration members.
        ////       ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
        ////        Save the current background and foreground colors.
        ////       ConsoleColor currentBackground = Console.BackgroundColor;
        ////        ConsoleColor currentForeground = Console.ForegroundColor;

        ////        Display all foreground colors except the one that matches the background.
        ////       Console.WriteLine("All the foreground colors except {0}, the background color:",
        ////                              currentBackground);
        ////            foreach (var color in colors)
        ////            {
        ////                if (color == currentBackground) continue;

        ////                Console.ForegroundColor = color;
        ////                Console.WriteLine("   The foreground color is {0}.", color);
        ////            }
        ////    Console.WriteLine();
        ////      Restore the foreground color.
        ////     Console.ForegroundColor = currentForeground;

        ////    Display each background color except the one that matches the current foreground color.
        ////   Console.WriteLine("All the background colors except {0}, the foreground color:",
        ////                       currentForeground);
        ////     foreach (var color in colors)
        ////     {
        ////         if (color == currentForeground) continue;

        ////         Console.BackgroundColor = color;
        ////         Console.WriteLine("   The background color is {0}.", color);
        ////     }

        ////Restore the original console colors.
        ////Console.ResetColor();
        ////     Console.WriteLine("\nOriginal colors restored...");
        ////    
        ////    
        ////    
        ////    
        ////    
        ////    
        ////    
        ////    
        ////    
        ////    
        ////    
        ////    
        ////    
        ////    
        ////    
        ////    
        ////    
    }
}
