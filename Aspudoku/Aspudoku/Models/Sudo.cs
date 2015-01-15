using Sudoku;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aspudoku.Models
{
    public class Sudo
    {
        Game gm = new Game();
        public short[,] puzzle { get; set; }
        public Sudo()
        {
            puzzle = new short[9, 9];
        }

        public void Create ()
        {
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