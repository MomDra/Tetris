using System;
using System.Threading;
using System.Timers;

namespace Tetris
{
    class Program
    {
        static void Main(string[] args)
        {
            TScreen screen = new TScreen(10, 15);
            BlockData blockData = new BlockData();
            blockData.DataInit();
            Block block = new Block(screen, blockData);

            System.Timers.Timer timer = new System.Timers.Timer(1000);
            timer.Elapsed += block.Down;
            timer.Enabled = true;

            while (!screen.CheckGameOver()) { 
                screen.Render();
                screen.Clear();
                block.Move();
                Thread.Sleep(50);
                Console.Clear();
            }

            timer.Enabled = false;
            Console.WriteLine("Game Over!");
        }
    }
}
