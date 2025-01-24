namespace TypingTest
{
    internal class Language
    {
        public static string GetRussian(string symbol)
        {
            switch (symbol)
            {
                case "oem3": return "ё";
                case "q": return "й";
                case "w": return "ц";
                case "e": return "у";
                case "r": return "к";
                case "t": return "е";
                case "y": return "н";
                case "u": return "г";
                case "i": return "ш";
                case "o": return "щ";
                case "p": return "з";
                case "oem4": return "х";
                case "oem6": return "ъ";
                case "a": return "ф";
                case "s": return "ы";
                case "d": return "в";
                case "f": return "а";
                case "g": return "п";
                case "h": return "р";
                case "j": return "о";
                case "k": return "л";
                case "l": return "д";
                case "oem1": return "ж";
                case "oem7": return "э";
                case "z": return "я";
                case "x": return "ч";
                case "c": return "с";
                case "v": return "м";
                case "b": return "и";
                case "n": return "т";
                case "m": return "ь";
                case "oemcomma": return "б";
                case "oemperiod": return "ю";
                case "spacebar": return " ";
                case "backspace": return "?";
            }
            return symbol;
        }

    }
}
