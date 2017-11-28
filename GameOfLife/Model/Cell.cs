using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife.Model
{
    public class Cell
    {
        public CellCoordinates Coordinates { get; set; }
        public bool IsAlive { get; set; }
        //public bool StateChangedFromPreviousGen { get; set; } = false;

        public Cell(int x, int y)
        {
            Coordinates = new CellCoordinates(x, y);
        }

       
    }
}
