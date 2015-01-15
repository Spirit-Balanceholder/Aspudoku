using Sudoku;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aspudoku.Models
{
    public static class Sudo
    {
        static Game gm;
        public static short[,] puzzle { get; set; }

        public static void Create ()
        {
            gm = new Game();
            puzzle = new short[9, 9];
            gm.create();
            for (int x = 0; x < 9; x++)
            {
                for (int y = 0; y < 9; y++)
                {
                    gm.get((short)(x + 1), (short)(y + 1), out puzzle[x, y]);
                }
            }
        }
    }
}