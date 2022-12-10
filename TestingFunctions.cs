using static MyOwn_Arcanoid.ExtendetFunctions;

namespace MyOwn_Arcanoid
{
    public class TestingFunctions
    {
        public static void Main1(string[] args)
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
        }
    }
}