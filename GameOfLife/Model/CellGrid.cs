using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife.Model
{
    public class CellGrid
    {
        public Cell[,] Cells { get; private set; }
        public int Rows { get; private set; }
        public int Columns { get; private set; }

        public CellGrid(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
            Cells = new Cell[rows, columns];
            for (var x = 0; x < rows; x++)
            {
                for (var y = 0; y < rows; y++)
                {
                    Cells[x, y] = new Cell(x,y);
                }
            }
        }

        public CellGrid Clone()
        {
            var clone = new CellGrid(Rows, Columns);
            for (var x = 0; x < Rows; x++)
            {
                for (var y = 0; y < Columns; y++)
                {
                    clone.Cells[x, y].Coordinates.X = Cells[x, y].Coordinates.X;
                    clone.Cells[x, y].Coordinates.Y = Cells[x, y].Coordinates.Y;
                    clone.Cells[x, y].IsAlive= Cells[x, y].IsAlive;
                }
            }
            return clone;
        }
    }
}
