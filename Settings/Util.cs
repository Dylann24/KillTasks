using System;

namespace KillTasks.Settings
{
    public class Util
    {
        internal static ConsoleKeyInfo GetKeyInput(ConsoleColor promptColor, ConsoleColor answerColor, string promptIn)
        {
            //Begin input

            var precolor = Console.ForegroundColor;

            Console.ForegroundColor = promptColor;

            Console.WriteLine($"\n{promptIn}");

            Console.ForegroundColor = answerColor;

            var response = Console.ReadKey();

            Console.ForegroundColor = precolor;

            return response;
        }
    }
}
