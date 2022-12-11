using System.Media;
using System.Runtime.InteropServices;

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

        public static void PlayLooped(bool check, string path = null)
        {
            SoundPlayer wav = new SoundPlayer(path);
            if (check)
            {
                wav.Load();
                wav.Play();
            }
            else wav.Stop();
        }

        public static void AsciiArtWrite(string score, int left, int top)
        {
            int lefttemp = left;
            char[] c = score.ToCharArray();
            for(int i = 0;i<c.Length;i++)
            {
                string[] asciinum = AsciiFont(c[i]);
                for (int j = 0; j < asciinum.Length; j++)
                {
                    Console.SetCursorPosition(lefttemp,top+j);
                    Console.Write(asciinum[j]);
                }
                lefttemp += asciinum[0].Length + 2;
            }
        }

        private static string[] AsciiFont(char s)
        {
            switch (s)
            {
                case '0':
                    string[] zero =
                    {
                        "  _|  ",
                        "_|  _|",
                        "_|  _|",
                        "_|  _|",
                        "  _|  "
                    };
                    return zero;
                case '1':
                    string[] one =
                    {
                        "   _|",
                        " _|_|",
                        "   _|",
                        "   _|",
                        "   _|"
                    };
                    return one;
                case '2':
                    string[] two =
                    {
                        "  _|_|  ",
                        "_|    _|",
                        "     _| ",
                        "   _|   ",
                        "_|_|_|_|"
                    };
                    return two;
                case '3':
                    string[] three =
                    {
                        "_|_|_|  ",
                        "      _|",
                        "  _|_|  ",
                        "      _|",
                        "_|_|_|  "
                    };
                    return three;
                case '4':
                    string[] four =
                    {
                        "_|  _|  ",
                        "_|  _|  ",
                        "_|_|_|_|",
                        "    _|  ",
                        "    _|  "
                    };
                    return four;
                case '5':
                    string[] five =
                    {
                        "_|_|_|_|",
                        "_|      ",
                        "_|_|_|  ",
                        "      _|",
                        "_|_|_|  "
                    };
                    return five;
                case '6':
                    string[] six =
                    {
                        "  _|_|_|",
                        "_|      ",
                        "_|_|_|  ",
                        "_|    _|",
                        "  _|_|  "
                    };
                    return six;
                case '7':
                    string[] seven =
                    {
                        "_|_|_|_|_|",
                        "        _|",
                        "      _|  ",
                        "    _|    ",
                        "  _|      "
                    };
                    return seven;
                case '8':
                    string[] eight =
                    {
                        "  _|_|  ",
                        "_|    _|",
                        "  _|_|  ",
                        "_|    _|",
                        "  _|_|  "
                    };
                    return eight;
                case '9':
                    string[] nine =
                    {
                        "  _|_|  ",
                        "_|    _|",
                        "  _|_|_|",
                        "      _|",
                        "_|_|_|  "
                    };
                    return nine;
                default:
                    return new []{"1","2"};
            }
        }
    }

    public class Program1
    {
        [DllImport("kernel32.dll", ExactSpelling = true)]
        private static extern IntPtr GetConsoleWindow();

        public static IntPtr ThisConsole = GetConsoleWindow();

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        public const int HIDE = 0;
        public const int MAXIMIZE = 3;
        private const int MINIMIZE = 6;
        private const int RESTORE = 9;

    }
}