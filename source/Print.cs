using System.Text.RegularExpressions;

namespace TypingTest
{
    internal class Print
    {
        public static int left = 0;
        public static int top = 0;
        public static int[] autoLeft;
        public static int[] autoLength;
        public static string[] auto;
        public static void Center(string text)
        {
            left = Console.WindowWidth / 2 - text.Length / 2;
            top = Console.WindowHeight / 2 - 1;
            Console.SetCursorPosition(left, top);
            Console.WriteLine(text);
        }
        public static void Auto(string text)
        {
            int length = text.Length;
            int cursor = 0;

            while (length > Console.WindowWidth)
            {
                string newLine = text.Substring(cursor, Console.WindowWidth - Console.WindowWidth / 5);
                int lineLength = newLine.LastIndexOf(' ');
                cursor += lineLength;
                text = text.Insert(cursor, "\n");
                length -= lineLength;
            }

            string[] lines = Regex.Split(text, "\r\n|\r|\n");

            auto = lines;
            autoLength = new int[lines.Length];
            for (int i = 0; i < lines.Length; i++) autoLength[i] = lines[i].Length;
            autoLeft = new int[lines.Length];

            int left = 0;
            int top = (Console.WindowHeight / 2) - (lines.Length / 2) - 1;
            Print.top = top;
            int center = Console.WindowWidth / 2;

            for (int i = 0; i < lines.Length; i++)
            {
                left = center - (lines[i].Length / 2);
                Console.SetCursorPosition(left, top);
                Console.WriteLine(lines[i]);
                top = Console.CursorTop;
                autoLeft[i] = left;
            }
        }
        public static void OneWord(string text, int index)
        {
            string[] textArr = text.Split(' ');
            left = Console.WindowWidth / 2 - textArr[index].Length / 2;
            top = Console.WindowHeight / 2 - 1;
            Console.SetCursorPosition(left, top);
            Console.WriteLine(textArr[index]);
        }
        public static void Position(int left, int top, string text)
        {
            Console.SetCursorPosition(left, top);
            Console.WriteLine(text);
        }
        public static void Color(int left, int top, ConsoleColor color, string text)
        {
            Console.SetCursorPosition(left, top);
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        }
        public static void ArrayW(int left, int top, string[] text)
        {
            Console.SetCursorPosition(left, top);
            for (int i = 0; i < text.Length; i++) Console.Write(text[i]);
            Console.WriteLine();
        }
        public static void Array(int left, int top, string text)
        {
            string[] lines = text.Split("\n");
            for (int i = 0; i < lines.Length; i++)
            {
                Console.SetCursorPosition(left, top);
                Console.WriteLine(lines[i]);
                top++;
            }
        }
        public static void End(int left, int top, string title, string description)
        {
            Console.SetCursorPosition(left, top);
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(title);
            Console.ResetColor();
            Console.Write(description);
        }
    }
}
