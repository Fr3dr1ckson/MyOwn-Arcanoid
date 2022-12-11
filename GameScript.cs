namespace MyOwn_Arcanoid
{
    static class ObjectID
    {
        public const int Ball = 200;
        public const int RedBrick = 300;
        public const int BlueBrick = 310;
        public const int YellowBrick = 320;
        public const int GreenBrick = 330;
        public const int MagentaBrick = 340;
        public const int ArmorBrick = 350;
        public const int PlayerBoard = 100;
        public const int PlayerBoardCorner = 110;
        public const int Wall = 120;
    }

    internal class Levels
    {
        private int[,] GameBoard = new int[32, 8];
        
        
        private void LevelFilling(int[,] level)
        {
            for (int i = 0; i < GameBoard.GetLength(0); i++)
            {
                for (int j = 0; j < GameBoard.GetLength(1); j++)
                {
                    if(j == GameBoard.GetLength(1)-1 || j == 0 || i == 0 )
                    {
                        level[i, j] = ObjectID.Wall;
                    }
                    level[i, j] = 0;
                }
            }
        }

        internal void Level1(int[,] level)
        {
            for (int i = 4; i < 10; i++)
            {
                int brickId = 0;
                switch (i)
                {
                    case 4:
                        brickId = ObjectID.ArmorBrick;
                        break;
                    case 5:
                        brickId = ObjectID.RedBrick;
                        break;
                    case 6:
                        brickId = ObjectID.BlueBrick;
                        break;
                    case 7:
                        brickId = ObjectID.YellowBrick;
                        break;
                    case 8:
                        brickId = ObjectID.MagentaBrick;
                        break;
                    case 9:
                        brickId = ObjectID.GreenBrick;
                        break;
                }
                for (int j = 1; j < level.GetLength(1)-1; j++)
                {
                    level[i, j] = brickId;
                }
            }
        }
    }

    internal class DotMovement
    {
        private static bool BlockAhead(int[,] level , int xBall, int yBall)
        {
            return level[xBall, yBall] is not 0 or ObjectID.PlayerBoardCorner or ObjectID.PlayerBoard or ObjectID.Wall;
        }
        private static bool UnbreakableAhead(int[,] level , int xBall, int yBall)
        {
            return level[xBall, yBall] is not 0 and ObjectID.PlayerBoardCorner or ObjectID.PlayerBoard or ObjectID.Wall;
        }
        internal static string MoveByX(int[,] level,int x, int y, bool up)
        {
            if (up)
            {
                for (int xPoz = x;; xPoz++)
                {
                    if(BlockAhead(level,xPoz+1,y))
                    {
                        level[xPoz + 1, y] = 0;
                        return "South";
                    }
                    if (UnbreakableAhead(level, xPoz + 1, y))
                    {
                        return "South";
                    }
                    level[xPoz + 1, y] = 2;
                    level[xPoz, y] = 0;
                }
            }
            for (int xPoz = x;; xPoz--)
            {
                if (BlockAhead(level,xPoz-1,y))
                    return "North";

                if (level[xPoz - 1,y] == 3)
                    return "NorthEast";
                
                level[xPoz - 1, y] = 2;
                level[xPoz, y] = 0;
            }
        }
        internal static string MoveByY(int[,] level,int x, int y, bool right)
        {
            if (right)
            {
                for (int yPoz = y;; yPoz++)
                {
                    if (level[x,yPoz + 1] != 0)
                    {
                        return "East";
                    }

                    level[x,yPoz + 1] = 2;
                    level[x,yPoz] = 0;
                }
            }
            for (int yPoz = y;; yPoz--)
            {
                if (yPoz - 1 != 0)
                    return "West";
                
                level[yPoz - 1, y] = 2;
                level[yPoz, y] = 0;
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