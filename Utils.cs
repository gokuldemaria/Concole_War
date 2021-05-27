using System;
namespace console_war.formats
{
    public class Utils
    {
        public static void ColorMaker(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            System.Console.WriteLine(text);
            Console.ResetColor();
        }
    }
}