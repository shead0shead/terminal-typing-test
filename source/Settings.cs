namespace TypingTest
{
    internal class Settings
    {
        // Основные настройки
        public static int mode = 1; // 1 - Обычный  2 - Одно слово

        // Настройки генератора текста
        public static int length = 25;
        public static string language = "english";

        // Цветовая схема
        public static ConsoleColor mistakes = ConsoleColor.Red;
        public static ConsoleColor correct = ConsoleColor.White;
        public static ConsoleColor background = ConsoleColor.DarkGray;
    }
    internal class Parameters
    {
        public static int index1;
        public static int index2;
        public static string text;
        public static string[] textCharArr;
        public static double wrongs;
    }
}
