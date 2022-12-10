using System.Media;

namespace MyOwn_Arcanoid
{
    public class ExtendetFunctions
    {
        public static void ClearLine()
        {
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, Console.CursorTop - 1);
        }

        public static void LineAnimation(char c)
        {
            for (int i = (Console.WindowWidth-1); i > 0; i-=15)
            {
                Console.WriteLine(new string(' ', i)+c);
                Thread.Sleep(1);
                ClearLine();
            }
            ClearLine();
        }
        public static void PlayLooped(bool check,string path = null){
            SoundPlayer mainScreen = new SoundPlayer(path);
            if (check)
            {
                mainScreen.Load();
                mainScreen.PlayLooping();
            }
            else mainScreen.Stop();
        }
    }
}