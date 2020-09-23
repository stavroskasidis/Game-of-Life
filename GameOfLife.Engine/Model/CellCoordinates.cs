using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife.Engine.Model
{
    public class CellCoordinates
    {
        public int Row { get; set; }
        public int Column { get; set; }

        public CellCoordinates(int row, int column)
        {
            this.Row = row;
            this.Column = column;
        }
    }
}
