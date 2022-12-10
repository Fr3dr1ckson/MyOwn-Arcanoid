using static MyOwn_Arcanoid.ExtendetFunctions;

namespace MyOwn_Arcanoid
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Console.SetWindowSize(200,40);
            PlayLooped(true,SoundLib.MainMenu);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            string blank = new string(' ', Console.WindowWidth/3);
            string s = blank + " _______  _______  _______  _______  _        _______ _________ ______  " + "\n" +
                       blank +"(  ___  )(  ____ )(  ____ \\(  ___  )( (    /|(  ___  )\\__   __/(  __  \\ " + "\n" +
                       blank +"| (   ) || (    )|| (    \\/| (   ) ||  \\  ( || (   ) |   ) (   | (  \\  )" + "\n" +
                       blank +"| (___) || (____)|| |      | (___) ||   \\ | || |   | |   | |   | |   ) |" + "\n" +
                       blank +"|  ___  ||     __)| |      |  ___  || (\\ \\) || |   | |   | |   | |   | |" + "\n" +
                       blank +"| (   ) || (\\ (   | |      | (   ) || | \\   || |   | |   | |   | |   ) |" + "\n" +
                       blank + "| )   ( || ) \\ \\__| (____/\\| )   ( || )  \\  || (___) |___) (___| (__/  )" + "\n" +
                       blank + "|/     \\||/   \\__/(_______/|/     \\||/    )_)(_______)\\_______/(______/ " + "\n";
            Console.WriteLine(new string('\n',Console.WindowHeight/3) + s);
            Console.ResetColor();
            ConsoleKey key;
            do
            {
                if (Console.KeyAvailable)
                {
                    key = Console.ReadKey(true).Key;
                    if (key == ConsoleKey.E)
                    {
                        break;
                    }
                }
                Thread.Sleep(700);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(new string(' ',Console.WindowWidth/2-7)+"Enter E, to start");
                Thread.Sleep(700);
                ClearLine();
            } while(true);
            PlayLooped(false,SoundLib.MainMenu);
            for (int i = 9; i > 0; i--)
            {
                Thread.Sleep(400);
                ClearLine();
                LineAnimation('<');
            }
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(new string(' ', 100) + "Level 1");
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}