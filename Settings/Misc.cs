using System;
using System.Diagnostics;
using System.Text;
using System.Threading;

namespace KillTasks.Settings
{
    public class Misc
    { 
        public static void Steam()
        {
            string processName = "steam";

            Process[] processes = Process.GetProcessesByName(processName);



            foreach(Process process in processes)

            {

                process.Kill();

            }
        }
        public static void Itunes()
        {
            string processName = "itunes";

            Process[] processes = Process.GetProcessesByName(processName);



            foreach(Process process in processes)

            {

                process.Kill();

            }
        }
        public static void Chrome()
        {
            string processName = "chrome";

            Process[] processes = Process.GetProcessesByName(processName);



            foreach(Process process in processes)

            {

                process.Kill();

            }
        }
        public static void VisualStudioCode()
        {
            string processName = "code";

            Process[] processes = Process.GetProcessesByName(processName);



            foreach(Process process in processes)

            {

                process.Kill();

            }
        }
        public static void VisualStudio()
        {
            string processName = "devenv";

            Process[] processes = Process.GetProcessesByName(processName);



            foreach(Process process in processes)

            {

                process.Kill();

            }
        }
        public static void Rider()
        {
            string processName = "rider64";

            Process[] processes = Process.GetProcessesByName(processName);



            foreach(Process process in processes)

            {

                process.Kill();

            }
        }
        public static void Discord()
        {
            string processName = "discord";

            Process[] processes = Process.GetProcessesByName(processName);



            foreach(Process process in processes)

            {

                process.Kill();

            }
        }
        public static void GTA()
        {
            string processName = "gta5";

            Process[] processes = Process.GetProcessesByName(processName);



            foreach(Process process in processes)

            {

                process.Kill();

            }
        }
        public static void F12021()
        {
            string processName = "F1_2021_dx12";

            Process[] processes = Process.GetProcessesByName(processName);



            foreach(Process process in processes)

            {

                process.Kill();

            }
        }
        public static void ETS()
        {
            string processName = "eurotrucks2";

            Process[] processes = Process.GetProcessesByName(processName);



            foreach(Process process in processes)

            {

                process.Kill();

            }
        }
        
        internal static void PrintDevInfo()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("(C) BruhDylann 2021 - All rights reserved.");
            Console.ForegroundColor = ConsoleColor.White;
        }
        
        internal static void exit()
        {
            if (AskForConfirmation("exit the application") == true)
            {
                Console.Clear();
                Console.WriteLine("Thank you for using the task kill menu!");
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("Closing application...");
                Thread.Sleep(2500);
                Environment.Exit(0);
            }
            return;
        }
        internal static bool AskForConfirmation(string OperationDisplayName)
        {
            Console.Clear();
            ConsoleKeyInfo cki = Util.GetKeyInput(ConsoleColor.Red, ConsoleColor.DarkCyan, $"Are you sure you want to {OperationDisplayName}? (Y/N)");
            switch (cki.Key)
            {
                case ConsoleKey.Y:
                    return true;

                default:
                    PrintDevInfo();
                    return false;
            }
        }
    }
}