using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife.Model
{
    public class Generation
    {
        public Cell[,] Cells { get; private set; }
        public int Rows { get; private set; }
        public int Columns { get; private set; }

        public Generation(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
            Cells = new Cell[rows, columns];
            for (var row = 0; row < rows; row++)
            {
                for (var column = 0; column < columns; column++)
                {
                    Cells[row, column] = new Cell(row, column);
                }
            }
        }
    }
}
