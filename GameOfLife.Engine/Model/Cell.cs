using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife.Engine.Model
{
    public class Cell
    {
        public CellCoordinates Coordinates { get; set; }
        public bool IsAlive { get; set; }

        public Cell(int row, int column)
        {
            Coordinates = new CellCoordinates(row, column);
        }


    }
}
