using System;
using KillTasks.Settings;
using System.Threading;

namespace KillTasks.Menus
{
    public class Games
    {
        public static void VideoGames()
            {
                AppsMenu:
                Misc.PrintDevInfo();
                Console.WriteLine("Applications");
                Console.WriteLine("----------------");
                Console.WriteLine("[1] GTA 5");
                Console.WriteLine("[2] F1 2021");
                Console.WriteLine("[3] Euro Truck Simulator 2");
                Console.WriteLine("[4] Return to the main menu");

                switch (Util.GetKeyInput(ConsoleColor.Red, ConsoleColor.Red, "Please pick an option:").Key)
                {
                    case ConsoleKey.D1:
                        Misc.GTA();
                        goto AppsMenu;

                    case ConsoleKey.D2:
                        Misc.F12021();
                        goto AppsMenu;

                    case ConsoleKey.D3:
                        Misc.ETS();
                        goto AppsMenu;

                    case ConsoleKey.D4:
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