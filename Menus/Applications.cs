using System;
using KillTasks.Settings;
using System.Threading;

namespace KillTasks.Menus
{
    public class Applications
    {
        public static void Apps()
        {
            AppsMenu:
            Misc.PrintDevInfo();
            Console.WriteLine("Applications");
            Console.WriteLine("----------------");
            Console.WriteLine("[1] Steam");
            Console.WriteLine("[2] Chrome");
            Console.WriteLine("[3] Visual Studio");
            Console.WriteLine("[4] Visual Studio Code");
            Console.WriteLine("[5] Rider");
            Console.WriteLine("[7] Discord");
            Console.WriteLine("[8] Itunes");
            Console.WriteLine("[9] Return to the main menu");
            
            switch (Util.GetKeyInput(ConsoleColor.Red, ConsoleColor.Red, "Please pick an option:").Key)
            {
                case ConsoleKey.D1:
                    Misc.Steam();
                    goto AppsMenu;

                case ConsoleKey.D2:
                    Misc.Chrome();
                    goto AppsMenu;
                    
                case ConsoleKey.D3:
                    Misc.VisualStudio();
                    goto AppsMenu;
                    
                case ConsoleKey.D4:
                    Misc.VisualStudioCode();
                    goto AppsMenu;
                    
                case ConsoleKey.D5:
                    Misc.Rider();
                    goto AppsMenu;
                    
                case ConsoleKey.D6:
                    Misc.Steam();
                    goto AppsMenu;
                    
                case ConsoleKey.D7:
                    Misc.Discord();
                    goto AppsMenu;
                    
                case ConsoleKey.D8:
                    Misc.Itunes();
                    goto AppsMenu;

                case ConsoleKey.D9:
                    Program.Main();
                    goto AppsMenu;
                    
                default:
                    Console.WriteLine("Error: Input not recognised! Returning to main menu!");
                    Thread.Sleep(2500);
                    goto AppsMenu;
            }
        }
    }
}