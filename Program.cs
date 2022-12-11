using System.Text;
using MyOwn_Arcanoid;
using static MyOwn_Arcanoid.ExtendetFunctions;



namespace MyOwn_Arcanoid
{
    internal class Program
    {
        
        public static void Intro()
        {
            PlayLooped(true,SoundLib.Falling);
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            string blankHorisontal = new string(' ', Console.WindowWidth/3);
            string blankVertical = new string('\n',Console.WindowHeight/3);
            string[] s = {" _______  _______  _______  _______  _        _______ _________ ______  ",
                "(  ___  )(  ____ )(  ____ \\(  ___  )( (    /|(  ___  )\\__   __/(  __  \\ ",
                "| (   ) || (    )|| (    \\/| (   ) ||  \\  ( || (   ) |   ) (   | (  \\  )",
                "| (___) || (____)|| |      | (___) ||   \\ | || |   | |   | |   | |   ) |",
                "|  ___  ||     __)| |      |  ___  || (\\ \\) || |   | |   | |   | |   | |",
                "| (   ) || (\\ (   | |      | (   ) || | \\   || |   | |   | |   | |   ) |",
                "| )   ( || ) \\ \\__| (____/\\| )   ( || )  \\  || (___) |___) (___| (__/  )",
                "|/     \\||/   \\__/(_______/|/     \\||/    )_)(_______)\\_______/(______/ "};
            string strHighScore = 
                "██   ██ ██  ██████  ██   ██     ███████  ██████  ██████  ██████  ███████        " + '\n' + 
                "██   ██ ██ ██       ██   ██     ██      ██      ██    ██ ██   ██ ██          ██ " + '\n' + 
                "███████ ██ ██   ███ ███████     ███████ ██      ██    ██ ██████  █████          " + '\n' +        
                "██   ██ ██ ██    ██ ██   ██          ██ ██      ██    ██ ██   ██ ██          ██ " + '\n' + 
                "██   ██ ██  ██████  ██   ██     ███████  ██████  ██████  ██   ██ ███████        ";
            /*string strHighScore = 
                " |_|   |_| |_|             |_|             _|_|_|_|                                    |_|        _   " + '\n' + 
                " |_|   |_|        |_|_|_|  |_|_|_|        |_|_ _       |_|_|_|    _|_|    _| _|_|    |_|_|_|     |_|  " + '\n' + 
                " |_|_|_|_|  _|  |_|    |_| |_|    _|        |_|_|_    |_|        _|   _|  _|_|      _|_|_|_|          " + '\n' + 
                " |_|    _|  _|  |_|    |_| |_|    _|       _ _ _|_|   |_|        _|   _|  _|        _|            _   " + '\n' + 
                " |_|    _|  _|     |_|_|_| |_|    _|      |_|_|_|      |_|_|_|    _|_|    _|          _|_|_|     |_|  " + '\n' +
                "                        _|                                                                            " + '\n' +
                "                  |_|_|_|                                                                             ";*/
            for (int i = 0; i < Console.WindowHeight / 3; i++)
            {
                for (int j = 0; j < i;j++)
                {
                    Console.SetCursorPosition(0,j);
                    Console.Write(new string(' ',Console.WindowWidth));
                    Console.SetCursorPosition(0, j);
                }
                for (int j = i; j < 8+i; j++)
                {
                    Console.SetCursorPosition(0,j);
                    Console.Write(blankHorisontal+s[j-i]);
                }
                Thread.Sleep(80);
            }
            Thread.Sleep(1000);
            Console.WriteLine();
            Console.SetCursorPosition(0,2);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(strHighScore);
            AsciiArtWrite("175295279",strHighScore.Length/5+2,2); 
            Console.ResetColor();
            Console.SetCursorPosition(0, Console.WindowHeight/3+8);
            Console.WriteLine();
            ConsoleKey key;
            PlayLooped(true,SoundLib.MainMenu);
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
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(new string(' ',Console.WindowWidth/2-10)+"Enter E, to start");
                Thread.Sleep(700);
                ClearLine();
            } while(true);
        }
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.OutputEncoding = Encoding.UTF8;
                Program1.ShowWindow(Program1.ThisConsole, Program1.MAXIMIZE);
                Intro();
                Console.ReadKey(true);
            }
            // for (int i = 9; i > 0; i--)
            // {
            //     Thread.Sleep(400);
            //     ClearLine();
            //     LineAnimation('<');
            // }
            // Console.ForegroundColor = ConsoleColor.DarkRed;
            // Console.WriteLine(new string(' ', 100) + "Level 1");
            // Console.ResetColor();
            // Console.ReadKey();
        }
        
        
       
    }
}