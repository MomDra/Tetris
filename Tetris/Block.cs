using System;
using System.Timers;
namespace Tetris
{
    public class Block
    {
        BlockType BT;
        BlockDir BD;
        BlockData blockdata;
        TScreen SC;
        int x = 0;
        int y = 0;
        
        public Block(TScreen screen, BlockData blockData)
        {
            SC = screen;
            blockdata = blockData;

            RandomBlockType();
        }

        private void RandomBlockType()
        {
            Random random = new Random();
            BT = (BlockType)random.Next((int)BlockType.MAX);
        }

        private void setBlock()
        {
            //y++;
            for(int i = 0; i<4; i++)
            {
                for(int j = 0; j<4; j++)
                {
                    if(blockdata.data[(int)BT][(int)BD][i][j] == "◼︎")
                    {
                        SC.SetBlock(i + y, j + x);
                    }
                }
            }
        }

        private bool CheckBlockDir()
        {

            BlockDir curr = BD;
            curr = (BlockDir)((int)++curr);
            if ((int)curr == (int)BlockDir.L + 1) curr = BlockDir.T;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (blockdata.data[(int)BT][(int)curr][i][j] == "◼︎")
                    {
                        if (j + x >= SC.X || SC.isBlock(y + i, x + j) || i + y >= SC.Y)
                        {
                            return false;
                        }
                    }
                }
            }

            return true;
        }
        private void setBlockDir()
        {
            if (CheckBlockDir())
            {
                BD = (BlockDir)((int)++BD);
                if ((int)BD == (int)BlockDir.L + 1) BD = BlockDir.T;
            }
        }

        private void StackBlock()
        {
            for(int i = 0; i<4; i++)
            {
                for(int j = 0; j<4; j++)
                {
                    if(blockdata.data[(int)BT][(int)BD][i][j] == "◼︎")
                        SC.SetStaticBlock(y + i, x + j);
                }
            }
        }

        private void Reset()
        {
            RandomBlockType();
            x = 0;
            y = 0;
        }

        private bool DownCheck()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (blockdata.data[(int)BT][(int)BD][i][j] == "◼︎")
                    {
                        if (i + y + 1 == SC.Y || SC.isBlock(y + i + 1, x + j))
                        {
                            StackBlock();
                            SC.DestoryCheck();
                            Reset();
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        private bool LeftCheck()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (blockdata.data[(int)BT][(int)BD][i][j] == "◼︎")
                    {
                        if (j + x -1 < 0 || SC.isBlock(y + i, x + j - 1))
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        private bool RightCheck()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (blockdata.data[(int)BT][(int)BD][i][j] == "◼︎")
                    {
                        if (j + x + 1 >= SC.X || SC.isBlock(y + i, x + j + 1))
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        public void Down()
        {
            if (DownCheck())
            {
                y++;
            }
        }

        public void Down(object Object, ElapsedEventArgs e)
        {
            if (DownCheck())
            {
                y++;
            }
        }

        private void Left()
        {
            if (LeftCheck()) x--;
        }

        private void Right()
        {
            if (RightCheck()) x++;
        }

        public void Move()
        {
            if (Console.KeyAvailable)
            {
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.RightArrow:
                        Right();
                        break;
                    case ConsoleKey.LeftArrow:
                        Left();
                        break;
                    case ConsoleKey.DownArrow:
                        Down();
                        break;
                    case ConsoleKey.Q:
                        setBlockDir();
                        break;
                }
            }
            setBlock();
        }
    }
}
