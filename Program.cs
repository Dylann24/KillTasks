using System;
using KillTasks.Settings;
using System.Threading;
using KillTasks.Menus;

namespace KillTasks
{
    internal class Program
    {
        public static void Main()
        {
            MainMenu:
            Misc.PrintDevInfo();
            Console.WriteLine("Welcome to the task kill menu!");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("[1] Games");
            Console.WriteLine("[2] Applications");
            Console.WriteLine("[3] Exit Application");

            switch (Util.GetKeyInput(ConsoleColor.Red, ConsoleColor.Red, "Please pick an option:").Key)
            {
                case ConsoleKey.D1:
                    Games.VideoGames();
                    goto MainMenu;

                case ConsoleKey.D2:
                    Applications.Apps();
                    goto MainMenu;
                    
                case ConsoleKey.D3:
                    Misc.exit();
                    goto MainMenu;

                default:
                    Console.WriteLine("Error: Input not recognised! Returning to main menu!");
                    Thread.Sleep(2500);
                    goto MainMenu;
            }
        }
    }
}
