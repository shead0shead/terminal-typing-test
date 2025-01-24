using System.Diagnostics;
using TypingTest;

restart:

Console.Title = "Shead / Typing Test / Меню";
Stopwatch sw = new Stopwatch();

Menu.Run();

int index1 = 0;
int index2 = 0;
string text = TextGenerator.GetRandomText();
char[] textarr = text.ToCharArray();
double wrongs = 0;

Console.ForegroundColor = Settings.background;
Print.Auto(text);
Console.ResetColor();
int[] left = Print.autoLeft;
int top = Print.top;
string[] arr = Print.auto;

bool check = true;
if (Settings.mode == 1) while (check) await Task.Run(() => Classic());
else while (check) await Task.Run(() => OneWord());

Console.ReadKey();
goto restart;

void End()
{
    Console.Title = "Shead / Typing Test / Итоги";
    sw.Stop();
    double seconds = Math.Round(Convert.ToDouble(sw.ElapsedMilliseconds) / 1000, 3);
    double percent = Math.Round(((textarr.Length - wrongs) / textarr.Length) * 100);
    double wpm = Math.Round(Convert.ToDouble(Settings.length) / seconds * 60);
    double cpm = Math.Round(textarr.Length / seconds * 60);
    Console.CursorVisible = false;
    Console.Clear();

    Print.Color(Console.WindowWidth / 2 - 16, Console.WindowHeight / 2 - 3, ConsoleColor.White, "Статистика:");
    Print.End(Console.WindowWidth / 2 - 16, Console.WindowHeight / 2 - 1, "Затраченное время: ", $"{seconds} секунд");
    Print.End(Console.WindowWidth / 2 - 16, Console.WindowHeight / 2, "Процент ошибок: ", $"{percent}%");
    Print.End(Console.WindowWidth / 2 - 16, Console.WindowHeight / 2 + 1, "Количество ошибок: ", $"{wrongs}");
    Print.End(Console.WindowWidth / 2 - 16, Console.WindowHeight / 2 + 2, "Слов в минуту: ", $"{wpm} WPM");
    Print.End(Console.WindowWidth / 2 - 16, Console.WindowHeight / 2 + 3, "Кликов в минуту: ", $"{cpm} CPM");

    Statistic.Write(seconds, percent, wrongs, wpm, cpm);
}
async Task Classic()
{
    Console.Title = "Shead / Typing Test / Печать";
    Console.SetCursorPosition(left[index2] + index1, top);
    ConsoleKey key = Console.ReadKey().Key;

    // Язык
    char symbol;
    if (Settings.language == "russian") symbol = Convert.ToChar(Language.GetRussian(key.ToString().ToLower()));
    else symbol = Convert.ToChar(Convert.ToChar(key).ToString().ToLower());

    sw.Start();

    // Проверка завершенности и конец строки
    if (index1 + 1 == arr[index2].ToCharArray().Length && index2 + 1 == arr.Length) { check = false; End(); }
    else if (index1 == arr[index2].Length && key == ConsoleKey.Spacebar) { index1 = 0; index2++; top++; }

    // Backspace
    if (key == ConsoleKey.Backspace)
    {
        index1--;
        if (index1 < 0 && index2 == 0) index1 = 0;
        else if (index1 < 0 && index2 > 0) { index2--; index1 = arr[index2].Length; index1--; top--; }
        Console.SetCursorPosition(left[index2] + index1, top);
        Console.ForegroundColor = Settings.background;
        Console.Write(arr[index2].ToCharArray()[index1]);
        Console.ResetColor();
        Console.SetCursorPosition(left[index2] + 1 + index1, top);
    }
    // Tab
    else if (key == ConsoleKey.Tab)
    {

    }
    // Не правильно
    else if (arr[index2].ToCharArray()[index1] != symbol)
    {
        Console.SetCursorPosition(left[index2] + index1, top);
        Console.ForegroundColor = Settings.mistakes;
        Console.Write(arr[index2].ToCharArray()[index1]);
        Console.ResetColor();
        index1++;
        wrongs++;
    }
    // Правильно
    else
    {
        Console.SetCursorPosition(left[index2] + index1, top);
        Console.ForegroundColor = Settings.correct;
        Console.Write(arr[index2].ToCharArray()[index1]);
        Console.ResetColor();
        index1++;
    }
}
async Task ClassicWithBoard()
{
    Console.Title = "Shead / Typing Test / Печать";
    Console.SetCursorPosition(left[index2] + index1, top);
    ConsoleKey key = Console.ReadKey().Key;

    // Язык
    char symbol;
    if (Settings.language == "russian") symbol = Convert.ToChar(Language.GetRussian(key.ToString().ToLower()));
    else symbol = Convert.ToChar(Convert.ToChar(key).ToString().ToLower());

    sw.Start();

    // Проверка завершенности и конец строки
    if (index1 + 1 == arr[index2].ToCharArray().Length && index2 + 1 == arr.Length) { check = false; Console.Clear(); End(); }
    else if (index1 == arr[index2].Length && key == ConsoleKey.Spacebar) { index1 = 0; index2++; top++; }

    // Backspace
    if (key == ConsoleKey.Backspace)
    {
        index1--;
        if (index1 < 0 && index2 == 0) index1 = 0;
        else if (index1 < 0 && index2 > 0) { index2--; index1 = arr[index2].Length; index1--; top--; }
        Console.SetCursorPosition(left[index2] + index1, top);
        Console.ForegroundColor = Settings.background;
        Console.Write(arr[index2].ToCharArray()[index1]);
        Console.ResetColor();
        Console.SetCursorPosition(left[index2] + 1 + index1, top);
    }
    // Не правильно
    else if (arr[index2].ToCharArray()[index1] != symbol)
    {
        Console.SetCursorPosition(left[index2] + index1, top);
        Console.ForegroundColor = Settings.mistakes;
        Console.Write(arr[index2].ToCharArray()[index1]);
        Console.ResetColor();
        index1++;
        wrongs++;
    }
    // Правильно
    else
    {
        Console.SetCursorPosition(left[index2] + index1, top);
        Console.ForegroundColor = Settings.correct;
        Console.Write(arr[index2].ToCharArray()[index1]);
        Console.ResetColor();
        index1++;
    }

    Board.KeyBoardShow(key);
}
async Task OneWord()
{
    Console.Title = "Shead / Typing Test / Печать";
    Console.Clear();
    Console.SetCursorPosition(Console.WindowWidth / 2 - text.Split(' ')[index2].Length / 2, Console.WindowHeight / 2 - 1);
    Console.WriteLine(text.Split(' ')[index2]);
    Console.SetCursorPosition(Console.WindowWidth / 2 - text.Split(' ')[index2].Length / 2 + index1, Console.WindowHeight / 2 - 1);
    ConsoleKey key = Console.ReadKey().Key;

    // Язык
    char symbol;
    if (Settings.language == "russian") symbol = Convert.ToChar(Language.GetRussian(key.ToString().ToLower()));
    else symbol = Convert.ToChar(Convert.ToChar(key).ToString().ToLower());

    sw.Start();

    // Проверка завершенности и конец строки
    if (index1 == text.Split(' ')[index2].Length && index2 == text.Split(' ').Length - 1) { check = false; End(); }
    else if (index1 == text.Split(' ')[index2].Length) { index1 = 0; index2++; }

    // Backspace
    if (key == ConsoleKey.Backspace)
    {
        index1--;
        if (index1 < 0 && index2 == 0) index1 = 0;
        Console.SetCursorPosition(left[index2] + index1, top);
        Console.ForegroundColor = Settings.background;
        Console.Write(arr[index2].ToCharArray()[index1]);
        Console.ResetColor();
        Console.SetCursorPosition(left[index2] + 1 + index1, top);
    }
    // Неправильно
    else if (text.Split(' ')[index2].ToCharArray()[index1] != symbol)
    {
        Console.SetCursorPosition((Console.WindowWidth / 2 - text.Split(' ')[index2].Length / 2), Console.WindowHeight / 2 - 1);
        Console.ForegroundColor = Settings.mistakes;
        Console.Write(text.Split(' ')[index2].ToCharArray()[index1]);
        Console.ResetColor();
        index1++;
        wrongs++;
    }
    // Правильно
    else
    {
        Console.SetCursorPosition((Console.WindowWidth / 2 - text.Split(' ')[index2].Length / 2) + index1, Console.WindowHeight / 2 - 1);
        Console.ForegroundColor = Settings.correct;
        Console.Write(text.Split(' ')[index2].ToCharArray()[index1]);
        Console.ResetColor();
        index1++;
    }
}