using static MyOwn_Arcanoid.ExtendetFunctions;

namespace MyOwn_Arcanoid
{
    public class TestingFunctions
    {
        public static void Main1(string[] args)
        {
	        Console.Write("COCK: ");
            int x = int.Parse(Console.ReadLine());
            if(x is not 0 and 5)
                Console.Write("Hello"!);
            else
            {
                Console.Write("DICK");
            }
        }
    }
}