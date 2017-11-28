using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife.Model
{
    public class CellCoordinates
    {
        public int X { get; set; }
        public int Y { get; set; }

        public CellCoordinates(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}
