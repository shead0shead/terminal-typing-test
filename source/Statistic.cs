using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypingTest
{
    internal class Statistic
    {
        public static void Write(double time, double percent, double wrongs, double wpm, double cpm)
        {
            FileInfo fileInf = new FileInfo("D:\\statistic.txt");
            if (!fileInf.Exists) File.Create("D:\\statistic.txt");
            string[] dataLines = File.ReadAllLines("D:\\statistic.txt");
            if (dataLines.Length == 0) File.AppendAllText("D:\\statistic.txt", $"{DateTime.Now}|/|{Settings.language}|/|{Settings.length}|/|{time}|/|{percent}|/|{wrongs}|/|{wpm}|/|{cpm}");
            else File.AppendAllText("D:\\statistic.txt", $"\n{DateTime.Now}|/|{Settings.language}|/|{Settings.length}|/|{time}|/|{percent}|/|{wrongs}|/|{wpm}|/|{cpm}");
        }
        public static void Table(string path)
        {
            int page = 1;

            mark:

            Console.Clear();
            Console.CursorVisible = false;
            Console.SetCursorPosition(1, 1);
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            for (int i = 0; i < Console.WindowWidth - 2; i++) Console.Write(" ");

            Print.Position(3, 1, "Дата");
            Print.Position(25, 1, "Язык");
            Print.Position(36, 1, "Слова");
            Print.Position(46, 1, "Время");
            Print.Position(60, 1, "Процент");
            Print.Position(73, 1, "Кол-во ошибок");
            Print.Position(97, 1, "WPM");
            Print.Position(112, 1, "CPM");

            string[] dataLines = File.ReadAllLines(path);
            for (int i = 0; i < dataLines.Length; i++)
            {
                if (i < (Console.WindowHeight - 6) * page && i > (Console.WindowHeight - 6) * (page - 1) - 1)
                {
                    string[] dataOfLine = dataLines[i].Split("|/|");
                    if ((i + 1) % 2 == 0) Console.BackgroundColor = ConsoleColor.Gray;
                    else Console.BackgroundColor = ConsoleColor.DarkGray;
                    Console.SetCursorPosition(1, 3 + i - ((page - 1) * (Console.WindowHeight - 6)));
                    for (int j = 0; j < Console.WindowWidth - 2; j++) Console.Write(" ");
                    Print.Position(3, 3 + i - ((page - 1) * (Console.WindowHeight - 6)), $"{dataOfLine[0]}");
                    Print.Position(25, 3 + i - ((page - 1) * (Console.WindowHeight - 6)), $"{dataOfLine[1]}");
                    Print.Position(36, 3 + i - ((page - 1) * (Console.WindowHeight - 6)), $"{dataOfLine[2]}");
                    Print.Position(46, 3 + i - ((page - 1) * (Console.WindowHeight - 6)), $"{dataOfLine[3]} сек");
                    Print.Position(60, 3 + i - ((page - 1) * (Console.WindowHeight - 6)), $"{dataOfLine[4]}%");
                    Print.Position(73, 3 + i - ((page - 1) * (Console.WindowHeight - 6)), $"{dataOfLine[5]}");
                    Print.Position(97, 3 + i - ((page - 1) * (Console.WindowHeight - 6)), $"{dataOfLine[6]}");
                    Print.Position(112, 3 + i - ((page - 1) * (Console.WindowHeight - 6)), $"{dataOfLine[7]}");
                }
            }

            Console.ResetColor();
            Console.SetCursorPosition(1, Console.WindowHeight - 2);
            Console.WriteLine(" W A - выбор страницы   Tab - вернуться назад");

            Console.SetCursorPosition(Console.WindowWidth - 12, Console.WindowHeight - 2);
            if (page < 10) Console.WriteLine($"Страница 0{page}");
            else Console.WriteLine($"Страница {page}");

            Console.SetCursorPosition(1, 1);
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.White;

            ConsoleKey key = Console.ReadKey().Key;
            if (key == ConsoleKey.W) page--;
            else if (key == ConsoleKey.S) page++;

            if (page < 1) page = dataLines.Length / (Console.WindowHeight - 6) + 1;
            else if (page > dataLines.Length / (Console.WindowHeight - 6) + 1) page = 1;

            Console.ResetColor();

            if (key == ConsoleKey.Tab) { }
            else goto mark;

            Console.CursorVisible = true;
        }
    }
}
