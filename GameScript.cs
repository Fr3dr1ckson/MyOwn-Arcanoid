namespace MyOwn_Arcanoid
{
    internal class Levels
    {
        private int[,] GameBoard = new int[32, 8];

        public int[,] Level1 => GameBoard;


        private void Level1Filling()
        {
            for (int i = 0; i < Level1.GetLength(0); i++)
            {
                for (int j = 0; j < Level1.GetLength(1); j++)
                {
                    Level1[i, j] = 0;
                    if (i is >2 and <9)
                    {
                        Level1[i, j] = 9;
                    }
                }
            }
        }
    }

    internal class DotMovement
    {
        public static bool IsCollapsing(int[,] level , int xBall, int yBall)
        {
            return level[xBall + 1, yBall] != 0 || level[xBall, yBall + 1] != 0 || level[xBall - 1, yBall] != 0 ||
                   level[xBall, yBall - 1] != 0 || level[xBall + 1, yBall + 1] != 0 || 
                   level[xBall-1,yBall-1] != 0 || level[xBall+1,yBall-1] != 0 || level[xBall-1,yBall+1] != 0;
        }

        internal static string MoveByX(int[,] level,int x, int y, bool up)
        {
            if (up)
            {
                for (int xPoz = x;; xPoz++)
                {
                    if (xPoz + 1 != 0)
                    {
                        return "South";
                    }

                    level[xPoz + 1, y] = 2;
                    level[xPoz, y] = 0;
                }
            }
            for (int xPoz = x;; xPoz--)
            {
                if (xPoz - 1 != 0 && xPoz != 3)
                    return "North";

                if (xPoz - 1 == 3)
                    return "NorthEast";
                
                level[xPoz - 1, y] = 2;
                level[xPoz, y] = 0;
            }
        }
    }
    internal class GameScript
    {

        public static void Gameplay(int[,] level)
        {
            for (int i = 4; i < level.GetLength(0);i++)
            {
                for (int j = 0; j < level.GetLength(1); j++)
                {
                    
                }
            }
        }
    }
    
    //Objects ID
    //0 - blank space
    //1 - wall or player board
    //2 - ball
    //3 - corner of player board
    //9 - regular blocks
}