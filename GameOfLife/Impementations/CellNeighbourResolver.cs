using GameOfLife.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameOfLife.Model;

namespace GameOfLife.Impementations
{
    public class CellNeighbourResolver : ICellNeighbourResolver
    {
        public CellCoordinates GetNeighbourCoordinates(Cell cell, Generation generation, NeighbourPosition position)
        {
            var maxRow = generation.Rows - 1;
            var maxColumn = generation.Columns - 1;
            var row = 0;
            var column = 0;
            switch (position)
            {
                case NeighbourPosition.TopLeft:
                    column = HandleOutOfBounds(cell.Coordinates.Column - 1, maxColumn);
                    row = HandleOutOfBounds(cell.Coordinates.Row - 1, maxRow);
                    break;
                case NeighbourPosition.Top:
                    column = cell.Coordinates.Column;
                    row = HandleOutOfBounds(cell.Coordinates.Row - 1, maxRow);
                    break;
                case NeighbourPosition.TopRight:
                    column = HandleOutOfBounds(cell.Coordinates.Column + 1, maxColumn);
                    row = HandleOutOfBounds(cell.Coordinates.Row - 1, maxRow);
                    break;
                case NeighbourPosition.Right:
                    column = HandleOutOfBounds(cell.Coordinates.Column + 1, maxColumn);
                    row = cell.Coordinates.Row;
                    break;
                case NeighbourPosition.BottomRight:
                    column = HandleOutOfBounds(cell.Coordinates.Column + 1, maxColumn);
                    row = HandleOutOfBounds(cell.Coordinates.Row + 1, maxRow);
                    break;
                case NeighbourPosition.Bottom:
                    column = cell.Coordinates.Column;
                    row = HandleOutOfBounds(cell.Coordinates.Row + 1, maxRow);
                    break;
                case NeighbourPosition.BottomLeft:
                    column = HandleOutOfBounds(cell.Coordinates.Column - 1, maxColumn);
                    row = HandleOutOfBounds(cell.Coordinates.Row + 1, maxRow);
                    break;
                case NeighbourPosition.Left:
                    row = cell.Coordinates.Row;
                    column = HandleOutOfBounds(cell.Coordinates.Column - 1, maxColumn);
                    break;
            }

            return new CellCoordinates(row, column);
        }

        private int HandleOutOfBounds(int coordinate, int maxCoordinateValue)
        {
            if (coordinate < 0)
            {
                return maxCoordinateValue;
            }
            else if (coordinate > maxCoordinateValue)
            {
                return 0;
            }
            else
            {
                return coordinate;
            }
        }
    }
}
