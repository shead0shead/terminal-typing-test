using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypingTest
{
    internal class Board
    {
        public static void KeyBoardShow(ConsoleKey key)
        {
            Print.Array(Console.WindowWidth / 2 - 17, 22, "Q  W  E  R  T  Y  U  I  O  P  {  }\n\n A  S  D  F  G  H  J  K  L  :  '\n\n  Z  X  C  V  B  N  M  <  >  ?");
            if (key == ConsoleKey.Q)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(Console.WindowWidth / 2 - 17 - 1, 22);
                Console.WriteLine(" Q ");
                Console.ResetColor();
            }
            if (key == ConsoleKey.W)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(Console.WindowWidth / 2 - 14 - 1, 22);
                Console.WriteLine(" W ");
                Console.ResetColor();
            }
            if (key == ConsoleKey.E)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(Console.WindowWidth / 2 - 11 - 1, 22);
                Console.WriteLine(" E ");
                Console.ResetColor();
            }
            if (key == ConsoleKey.R)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(Console.WindowWidth / 2 - 8 - 1, 22);
                Console.WriteLine(" R ");
                Console.ResetColor();
            }
            if (key == ConsoleKey.T)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(Console.WindowWidth / 2 - 5 - 1, 22);
                Console.WriteLine(" T ");
                Console.ResetColor();
            }
            if (key == ConsoleKey.Y)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(Console.WindowWidth / 2 - 2 - 1, 22);
                Console.WriteLine(" Y ");
                Console.ResetColor();
            }
            if (key == ConsoleKey.U)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(Console.WindowWidth / 2 + 1 - 1, 22);
                Console.WriteLine(" U ");
                Console.ResetColor();
            }
            if (key == ConsoleKey.I)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(Console.WindowWidth / 2 + 4 - 1, 22);
                Console.WriteLine(" I ");
                Console.ResetColor();
            }
            if (key == ConsoleKey.O)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(Console.WindowWidth / 2 + 7 - 1, 22);
                Console.WriteLine(" O ");
                Console.ResetColor();
            }
            if (key == ConsoleKey.P)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(Console.WindowWidth / 2 + 10 - 1, 22);
                Console.WriteLine(" P ");
                Console.ResetColor();
            }
            
        }
    }
}
