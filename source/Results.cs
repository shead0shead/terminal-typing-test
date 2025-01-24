using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypingTest
{
    internal class Results
    {
        protected static string circle = "       ▄▄█▀▀▀▀▀▀█▄       \n    ▄█▀▀          ▀▀█▄    \n  ▄█▀                ▀█▄  \n ▄█                    █▄ \n▄█                      █▄\n█                        █\n█                        █\n█                        █\n▀█                      █▀\n ▀█                    █▀ \n  ▀█▄                ▄█▀  \n    ▀█▄▄          ▄▄█▀    \n       ▀▀█▄▄▄▄▄▄█▀▀       ";
        protected static string square = "█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█\n█                       █\n█                       █\n█                       █\n█                       █\n█                       █\n█                       █\n█                       █\n█                       █\n█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█";
        protected static string square100 = "█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█\n█                                  █\n█                                  █\n█                                  █\n█                                  █\n█                                  █\n█                                  █\n█                                  █\n█                                  █\n█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█";
        protected static string num9 = "██████████\n██▀▀▀▀▀▀██\n██      ██\n██▄▄▄▄▄▄██\n██████████\n        ██\n        ██\n██████████";
        protected static string num8 = "██████████\n██▀▀▀▀▀▀██\n██      ██\n██▄▄▄▄▄▄██\n██▀▀▀▀▀▀██\n██      ██\n██▄▄▄▄▄▄██\n██████████";
        protected static string num7 = "██████████\n▀▀▀▀▀▀▀███\n      ███ \n     ███  \n    ███   \n   ███    \n  ███     \n ███      ";
        protected static string num6 = "██████████\n██▀▀▀▀▀▀▀▀\n██        \n██████████\n██▀▀▀▀▀▀██\n██      ██\n██▄▄▄▄▄▄██\n██████████";
        protected static string num5 = "██████████\n██▀▀▀▀▀▀▀▀\n██        \n██████████\n▀▀▀▀▀▀▀▀██\n        ██\n▄▄▄▄▄▄▄▄██\n██████████";
        protected static string num4 = "██      ██\n██      ██\n██      ██\n██▄▄▄▄▄▄██\n██████████\n        ██\n        ██\n        ██";
        protected static string num3 = "██████████\n▀▀▀▀▀▀▀▀██\n        ██\n██████████\n▀▀▀▀▀▀▀▀██\n        ██\n▄▄▄▄▄▄▄▄██\n██████████";
        protected static string num2 = "██████████\n▀▀▀▀▀▀▀▀██\n        ██\n██████████\n██▀▀▀▀▀▀▀▀\n██        \n██▄▄▄▄▄▄▄▄\n██████████";
        protected static string num1 = "   ▄███   \n ▄█▀███   \n    ███   \n    ███   \n    ███   \n    ███   \n    ███   \n██████████";
        protected static string num0 = "██████████\n██▀▀▀▀▀▀██\n██      ██\n██      ██\n██      ██\n██      ██\n██▄▄▄▄▄▄██\n██████████";
        public static void PercentCircle(int left, int top, int percent)
        {
            string leftNumber, rightNumber;

            if (percent.ToString().ToCharArray()[0] == '9') leftNumber = num9;
            else if (percent.ToString().ToCharArray()[0] == '8') leftNumber = num8;
            else if (percent.ToString().ToCharArray()[0] == '7') leftNumber = num7;
            else if (percent.ToString().ToCharArray()[0] == '6') leftNumber = num6;
            else if (percent.ToString().ToCharArray()[0] == '5') leftNumber = num5;
            else if (percent.ToString().ToCharArray()[0] == '4') leftNumber = num4;
            else if (percent.ToString().ToCharArray()[0] == '3') leftNumber = num3;
            else if (percent.ToString().ToCharArray()[0] == '2') leftNumber = num2;
            else if (percent.ToString().ToCharArray()[0] == '1') leftNumber = num1;
            else leftNumber = num0;

            if (percent.ToString().ToCharArray()[1] == '9') rightNumber = num9;
            else if (percent.ToString().ToCharArray()[1] == '8') rightNumber = num8;
            else if (percent.ToString().ToCharArray()[1] == '7') rightNumber = num7;
            else if (percent.ToString().ToCharArray()[1] == '6') rightNumber = num6;
            else if (percent.ToString().ToCharArray()[1] == '5') rightNumber = num5;
            else if (percent.ToString().ToCharArray()[1] == '4') rightNumber = num4;
            else if (percent.ToString().ToCharArray()[1] == '3') rightNumber = num3;
            else if (percent.ToString().ToCharArray()[1] == '2') rightNumber = num2;
            else if (percent.ToString().ToCharArray()[1] == '1') rightNumber = num1;
            else rightNumber = num0;

            if (percent == 100)
            {
                Print.Array(left, top, square100);
                Print.Array(left + 2, top + 1, num1);
                Print.Array(left + 13, top + 1, num0);
                Print.Array(left + 24, top + 1, num0);
            }
            else
            {
                Print.Array(left, top, square);
                Print.Array(left + 2, top + 1, leftNumber);
                Print.Array(left + 13, top + 1, rightNumber);
            }
        }
        public static void PrintResult(int percent)
        {
            int left;
            int top = Console.WindowHeight / 2 - 5;
            if (percent == 100) left = Console.WindowWidth / 2 - (square100.Split("\n")[0].Length + 35) / 2;
            else left = Console.WindowWidth / 2 - (square.Split("\n")[0].Length + 35) / 2;
            PercentCircle(left, top, percent);
        }
    }
}