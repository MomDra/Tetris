using System;
using System.Collections.Generic;

public class TScreen
{
    string[][] ArrBlock;
    string[][] staticBlock;
    public int X { get; }
    public int Y { get; }

    public TScreen(int _X, int _Y)
    {
        X = _X;
        Y = _Y;

        ArrBlock = new string[_Y][];
        staticBlock = new string[_Y][];

        for(int i = 0; i<_Y; i++)
        {
            ArrBlock[i] = new string[_X];
            staticBlock[i] = new string[_X];

            for (int j = 0; j < _X; j++)
            {
                ArrBlock[i][j] = "◻︎";
                staticBlock[i][j] = null;
            }
        }
    }

    public void Render()
    {
        for(int i = 0; i < ArrBlock.Length; i++)
        {
            for(int j = 0; j < ArrBlock[i].Length; j++)
            {
                if (staticBlock[i][j] == "◼︎") ArrBlock[i][j] = staticBlock[i][j];
                Console.Write(ArrBlock[i][j]);
            }

            Console.WriteLine();
        }
    }

    public void SetBlock(int y, int x)
    { 
        ArrBlock[y][x] = "◼︎";
    }

    public void SetStaticBlock(int y, int x)
    { 
        staticBlock[y][x] = "◼︎";
    }

    public bool isBlock(int y, int x)
    {
        if (staticBlock[y][x] == "◼︎") return true;

        return false;
    }

    public void DestoryCheck()
    {
        for (int i = Y - 1; i >= 0; i--)
        {
            bool isDestory = true;
            for (int j = 0; j < X; j++)
            {
                if (staticBlock[i][j] == null)
                {
                    isDestory = false;
                    break;
                }
            }

            if (isDestory)
            {
                for (int k = i; k > 0; k--)
                {
                    for (int l = 0; l < X; l++)
                    {
                        staticBlock[k][l] = staticBlock[k - 1][l];
                    }
                }

                i++;
            }
        }

    }

    public bool CheckGameOver()
    {
        for(int i = 0; i<X; i++)
        {
            if (staticBlock[0][i] == "◼︎") return true;
        }
        return false;
    }

    public void Clear()
    {
        for (int i = 0; i < Y; i++)
        { 

            for (int j = 0; j < X; j++)
            {
                ArrBlock[i][j] = "◻︎";
            }
        }
    }
    
}

