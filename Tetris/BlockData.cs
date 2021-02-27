using System;
namespace Tetris
{
    public class BlockData
    {
        public string[][][][] data;

        
        public void DataInit()
        {
            data = new string[7][][][];
            for(int i = 0; i<data.Length; i++)
            {
                data[i] = new string[4][][];
            }

            #region I
            data[(int)BlockType.I][(int)BlockDir.T] = new string[][]{
                new string[]{ "◼︎", "◼︎", "◼︎", "◼︎"},
                new string[]{ "◻", "◻︎", "◻︎", "◻︎"},
                new string[]{ "◻", "◻︎", "◻︎", "◻︎"},
                new string[]{ "◻", "◻︎", "◻︎", "◻︎"}
            };

            data[(int)BlockType.I][(int)BlockDir.R] = new string[][]{
                new string[]{ "◼︎", "◻︎", "◻︎", "◻︎"},
                new string[]{ "◼︎", "◻︎", "◻︎", "◻︎"},
                new string[]{ "◼︎", "◻︎", "◻︎", "◻︎"},
                new string[]{ "◼︎", "◻︎", "◻︎", "◻︎"}
            };

            data[(int)BlockType.I][(int)BlockDir.B] = new string[][]{
                new string[]{ "◼︎", "◼︎", "◼︎", "◼︎"},
                new string[]{ "◻", "◻︎", "◻︎", "◻︎"},
                new string[]{ "◻", "◻︎", "◻︎", "◻︎"},
                new string[]{ "◻", "◻︎", "◻︎", "◻︎"}
            };

            data[(int)BlockType.I][(int)BlockDir.L] = new string[][]{
                new string[]{ "◼︎", "◻︎", "◻︎", "◻︎"},
                new string[]{ "◼︎", "◻︎", "◻︎", "◻︎"},
                new string[]{ "◼︎", "◻︎", "◻︎", "◻︎"},
                new string[]{ "◼︎", "◻︎", "◻︎", "◻︎"}
            };
            #endregion
            #region J
            data[(int)BlockType.J][(int)BlockDir.T] = new string[][]{
                new string[]{ "◻︎", "◻︎", "◻︎", "◼︎"},
                new string[]{ "◼︎", "◼︎", "◼︎", "◼︎"},
                new string[]{ "◻︎", "◻︎", "◻︎", "◻︎"},
                new string[]{ "◻︎", "◻︎", "◻︎", "◻︎"}
            };

            data[(int)BlockType.J][(int)BlockDir.R] = new string[][]{
                new string[]{ "◼︎", "◻︎", "◻︎", "◻︎"},
                new string[]{ "◼︎", "◻︎", "◻︎", "◻︎"},
                new string[]{ "◼︎", "◻︎", "◻︎", "◻︎"},
                new string[]{ "◼︎", "◼︎", "◻︎", "◻︎"}
            };

            data[(int)BlockType.J][(int)BlockDir.B] = new string[][]{
                new string[]{ "◼︎", "◼︎", "◼︎", "◼︎"},
                new string[]{ "◼︎", "◻︎", "◻︎", "◻︎"},
                new string[]{ "◻︎", "◻︎", "◻︎", "◻︎"},
                new string[]{ "◻︎", "◻︎", "◻︎", "◻︎"}
            };

            data[(int)BlockType.J][(int)BlockDir.L] = new string[][]{
                new string[]{ "◼︎", "◼︎", "◻︎", "◻︎"},
                new string[]{ "◻︎", "◼︎", "◻︎", "◻︎"},
                new string[]{ "◻︎", "◼︎", "◻︎", "◻︎"},
                new string[]{ "◻︎", "◼︎", "◻︎", "◻︎"}
            };
            #endregion
            #region L
            data[(int)BlockType.L][(int)BlockDir.T] = new string[][]{
                new string[]{ "◼︎", "◻︎", "◻︎", "◻︎"},
                new string[]{ "◼︎", "◼︎", "◼︎", "◼︎"},
                new string[]{ "◻︎", "◻︎", "◻︎", "◻︎"},
                new string[]{ "◻︎", "◻︎", "◻︎", "◻︎"}
            };

            data[(int)BlockType.L][(int)BlockDir.R] = new string[][]{
                new string[]{ "◼︎", "◼︎", "◻︎", "◻︎"},
                new string[]{ "◼︎", "◻︎", "◻︎", "◻︎"},
                new string[]{ "◼︎", "◻︎", "◻︎", "◻︎"},
                new string[]{ "◼︎", "◻︎", "◻︎", "◻︎"}
            };

            data[(int)BlockType.L][(int)BlockDir.B] = new string[][]{
                new string[]{ "◼︎", "◼︎", "◼︎", "◼︎"},
                new string[]{ "◻︎", "◻︎", "◻︎", "◼︎"},
                new string[]{ "◻︎", "◻︎", "◻︎", "◻︎"},
                new string[]{ "◻︎", "◻︎", "◻︎", "◻︎"}
            };

            data[(int)BlockType.L][(int)BlockDir.L] = new string[][]{
                new string[]{ "◻︎", "◼︎", "◻︎", "◻︎"},
                new string[]{ "◻︎", "◼︎", "◻︎", "◻︎"},
                new string[]{ "◻︎", "◼︎", "◻︎", "◻︎"},
                new string[]{ "◼︎", "◼︎", "◻︎", "◻︎"}
            };
            #endregion
            #region O
            data[(int)BlockType.O][(int)BlockDir.T] = new string[][]{
                new string[]{ "◼︎", "◼︎", "◻︎", "◻︎"},
                new string[]{ "◼︎", "◼︎", "◻︎", "◻︎"},
                new string[]{ "◻︎", "◻︎", "◻︎", "◻︎"},
                new string[]{ "◻︎", "◻︎", "◻︎", "◻︎"}
            };

            data[(int)BlockType.O][(int)BlockDir.R] = new string[][]{
                new string[]{ "◼︎", "◼︎", "◻︎", "◻︎"},
                new string[]{ "◼︎", "◼︎", "◻︎", "◻︎"},
                new string[]{ "◻︎", "◻︎", "◻︎", "◻︎"},
                new string[]{ "◻︎", "◻︎", "◻︎", "◻︎"}
            };

            data[(int)BlockType.O][(int)BlockDir.B] = new string[][]{
                new string[]{ "◼︎", "◼︎", "◻︎", "◻︎"},
                new string[]{ "◼︎", "◼︎", "◻︎", "◻︎"},
                new string[]{ "◻︎", "◻︎", "◻︎", "◻︎"},
                new string[]{ "◻︎", "◻︎", "◻︎", "◻︎"}
            };

            data[(int)BlockType.O][(int)BlockDir.L] = new string[][]{
                new string[]{ "◼︎", "◼︎", "◻︎", "◻︎"},
                new string[]{ "◼︎", "◼︎", "◻︎", "◻︎"},
                new string[]{ "◻︎", "◻︎", "◻︎", "◻︎"},
                new string[]{ "◻︎", "◻︎", "◻︎", "◻︎"}
            };
            #endregion
            #region S
            data[(int)BlockType.S][(int)BlockDir.T] = new string[][]{
                new string[]{ "◻︎", "◼︎", "◼︎", "◻︎"},
                new string[]{ "◼︎", "◼︎", "◻︎", "◻︎"},
                new string[]{ "◻︎", "◻︎", "◻︎", "◻︎"},
                new string[]{ "◻︎", "◻︎", "◻︎", "◻︎"}
            };

            data[(int)BlockType.S][(int)BlockDir.R] = new string[][]{
                new string[]{ "◼︎", "◻︎", "◻︎", "◻︎"},
                new string[]{ "◼︎", "◼︎", "◻︎", "◻︎"},
                new string[]{ "◻︎", "◼︎", "◻︎", "◻︎"},
                new string[]{ "◻︎", "◻︎", "◻︎", "◻︎"}
            };

            data[(int)BlockType.S][(int)BlockDir.B] = new string[][]{
                new string[]{ "◻︎", "◼︎", "◼︎", "◻︎"},
                new string[]{ "◼︎", "◼︎", "◻︎", "◻︎"},
                new string[]{ "◻︎", "◻︎", "◻︎", "◻︎"},
                new string[]{ "◻︎", "◻︎", "◻︎", "◻︎"}
            };

            data[(int)BlockType.S][(int)BlockDir.L] = new string[][]{
                new string[]{ "◼︎", "◻︎", "◻︎", "◻︎"},
                new string[]{ "◼︎", "◼︎", "◻︎", "◻︎"},
                new string[]{ "◻︎", "◼︎", "◻︎", "◻︎"},
                new string[]{ "◻︎", "◻︎", "◻︎", "◻︎"}
            };
            #endregion
            #region T
            data[(int)BlockType.T][(int)BlockDir.T] = new string[][]{
                new string[]{ "◻︎", "◼︎", "◻︎", "◻︎"},
                new string[]{ "◼︎", "◼︎", "◼︎", "◻︎"},
                new string[]{ "◻︎", "◻︎", "◻︎", "◻︎"},
                new string[]{ "◻︎", "◻︎", "◻︎", "◻︎"}
            };

            data[(int)BlockType.T][(int)BlockDir.R] = new string[][]{
                new string[]{ "◼︎", "◻︎", "◻︎", "◻︎"},
                new string[]{ "◼︎", "◼︎", "◻︎", "◻︎"},
                new string[]{ "◼︎", "◻︎", "◻︎", "◻︎"},
                new string[]{ "◻︎", "◻︎", "◻︎", "◻︎"}
            };

            data[(int)BlockType.T][(int)BlockDir.B] = new string[][]{
                new string[]{ "◼︎", "◼︎", "◼︎", "◻︎"},
                new string[]{ "◻︎", "◼︎", "◻︎", "◻︎"},
                new string[]{ "◻︎", "◻︎", "◻︎", "◻︎"},
                new string[]{ "◻︎", "◻︎", "◻︎", "◻︎"}
            };

            data[(int)BlockType.T][(int)BlockDir.L] = new string[][]{
                new string[]{ "◻︎", "◼︎", "◻︎", "◻︎"},
                new string[]{ "◼︎", "◼︎", "◻︎", "◻︎"},
                new string[]{ "◻︎", "◼︎", "◻︎", "◻︎"},
                new string[]{ "◻︎", "◻︎", "◻︎", "◻︎"}
            };
            #endregion
            #region Z
            data[(int)BlockType.Z][(int)BlockDir.T] = new string[][]{
                new string[]{ "◼︎", "◼︎", "◻︎", "◻︎"},
                new string[]{ "◻︎", "◼︎", "◼︎", "◻︎"},
                new string[]{ "◻︎", "◻︎", "◻︎", "◻︎"},
                new string[]{ "◻︎", "◻︎", "◻︎", "◻︎"}
            };

            data[(int)BlockType.Z][(int)BlockDir.R] = new string[][]{
                new string[]{ "◻︎", "◼︎", "◻︎", "◻︎"},
                new string[]{ "◼︎", "◼︎", "◻︎", "◻︎"},
                new string[]{ "◼︎", "◻︎", "◻︎", "◻︎"},
                new string[]{ "◻︎", "◻︎", "◻︎", "◻︎"}
            };

            data[(int)BlockType.Z][(int)BlockDir.B] = new string[][]{
                new string[]{ "◼︎", "◼︎", "◻︎", "◻︎"},
                new string[]{ "◻︎", "◼︎", "◼︎", "◻︎"},
                new string[]{ "◻︎", "◻︎", "◻︎", "◻︎"},
                new string[]{ "◻︎", "◻︎", "◻︎", "◻︎"}
            };

            data[(int)BlockType.Z][(int)BlockDir.L] = new string[][]{
                new string[]{ "◻︎", "◼︎", "◻︎", "◻︎"},
                new string[]{ "◼︎", "◼︎", "◻︎", "◻︎"},
                new string[]{ "◼︎", "◻︎", "◻︎", "◻︎"},
                new string[]{ "◻︎", "◻︎", "◻︎", "◻︎"}
            };
            #endregion
        }
    }
}
