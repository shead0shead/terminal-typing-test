namespace TypingTest
{
    internal class Menu
    {
        public static void Run()
        {
            int line = 0;
            int item = 0;

            int l1i = 0;
            int l2i = 0;

            mark:

            Console.Clear();
            Console.CursorVisible = false;
            Console.SetCursorPosition(Console.WindowWidth / 2 - 13, Console.WindowHeight / 2 - 1);
            Console.WriteLine("Язык:  English  Russian  Germany");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 13, Console.WindowHeight / 2);
            Console.WriteLine("Слова:  10  25  50  75  100");

            if (line == 0)
            {
                Console.SetCursorPosition(Console.WindowWidth / 2 - 7 + 9 * item, Console.WindowHeight / 2 - 1);
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Gray;
                if (item == 0) Console.WriteLine(" English ");
                else if (item == 1) Console.WriteLine(" Russian ");
                else Console.WriteLine(" Germany ");
                Console.ResetColor();

                ConsoleKey key = Console.ReadKey().Key;
                if (key == ConsoleKey.Tab) Statistic.Table("D:\\statistic.txt");
                else if (key == ConsoleKey.D) item++;
                else if (key == ConsoleKey.A) item--;

                if (item > 2) item = 0;
                else if (item < 0) item = 2;

                if (key == ConsoleKey.Enter) l1i = item;
                else goto mark;

                line = 1;
                item = 0;
                goto mark;
            }
            else if (line == 1)
            {
                Console.SetCursorPosition(Console.WindowWidth / 2 - 7 + 9 * l1i, Console.WindowHeight / 2 - 1);
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Yellow;
                if (l1i == 0) Console.WriteLine(" English ");
                else if (l1i == 1) Console.WriteLine(" Russian ");
                else Console.WriteLine(" Germany ");
                Console.ResetColor();

                Console.SetCursorPosition(Console.WindowWidth / 2 - 6 + 4 * item, Console.WindowHeight / 2);
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Gray;
                if (item == 0) Console.WriteLine(" 10 ");
                else if (item == 1) Console.WriteLine(" 25 ");
                else if (item == 2) Console.WriteLine(" 50 ");
                else if (item == 3) Console.WriteLine(" 75 ");
                else Console.WriteLine(" 100 ");
                Console.ResetColor();

                ConsoleKey key = Console.ReadKey().Key;
                if (key == ConsoleKey.Tab) Statistic.Table("D:\\statistic.txt");
                else if (key == ConsoleKey.D) item++;
                else if (key == ConsoleKey.A) item--;

                if (item > 4) item = 0;
                else if (item < 0) item = 4;

                if (key == ConsoleKey.Enter) l2i = item;
                else goto mark;
            }

            Console.SetCursorPosition(Console.WindowWidth / 2 - 6 + 4 * l2i, Console.WindowHeight / 2);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Yellow;
            if (l2i == 0) Console.WriteLine(" 10 ");
            else if (l2i == 1) Console.WriteLine(" 25 ");
            else if (l2i == 2) Console.WriteLine(" 50 ");
            else if (l2i == 3) Console.WriteLine(" 75 ");
            else Console.WriteLine(" 100 ");
            Console.ResetColor();

            if (l1i == 0) Settings.language = "english";
            else if (l1i == 1) Settings.language = "russian";
            else Settings.language = "germany";

            if (l2i == 0) Settings.length = 10;
            else if (l2i == 1) Settings.length = 25;
            else if (l2i == 2) Settings.length = 50;
            else if (l2i == 3) Settings.length = 75;
            else Settings.length = 100;

            Thread.Sleep(150);
            Console.Clear();
            Console.CursorVisible = true;
        }
    }
}
