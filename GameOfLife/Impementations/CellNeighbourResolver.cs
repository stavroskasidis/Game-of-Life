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
        public CellCoordinates GetNeighbourCoordinates(Cell cell, CellGrid grid, NeighbourPosition position)
        {
            var maxX = grid.Rows - 1;
            var maxY = grid.Columns - 1;
            var x = 0;
            var y = 0;
            switch (position)
            {
                case NeighbourPosition.TopLeft:
                    x = HandleOutOfBounds(cell.Coordinates.X - 1, maxX);
                    y = HandleOutOfBounds(cell.Coordinates.Y - 1, maxY);
                    break;
                case NeighbourPosition.Top:
                    x = HandleOutOfBounds(cell.Coordinates.X - 1, maxX);
                    y = cell.Coordinates.Y;
                    break;
                case NeighbourPosition.TopRight:
                    x = HandleOutOfBounds(cell.Coordinates.X - 1, maxX);
                    y = HandleOutOfBounds(cell.Coordinates.Y + 1, maxY);
                    break;
                case NeighbourPosition.Right:
                    x = cell.Coordinates.X;
                    y = HandleOutOfBounds(cell.Coordinates.Y + 1, maxY);
                    break;
                case NeighbourPosition.BottomRight:
                    x = HandleOutOfBounds(cell.Coordinates.X + 1, maxX);
                    y = HandleOutOfBounds(cell.Coordinates.Y + 1, maxY);
                    break;
                case NeighbourPosition.Bottom:
                    x = HandleOutOfBounds(cell.Coordinates.X + 1, maxX);
                    y = cell.Coordinates.Y;
                    break;
                case NeighbourPosition.BottomLeft:
                    x = HandleOutOfBounds(cell.Coordinates.X + 1, maxX);
                    y = HandleOutOfBounds(cell.Coordinates.Y - 1, maxY);
                    break;
                case NeighbourPosition.Left:
                    x = cell.Coordinates.X;
                    y = HandleOutOfBounds(cell.Coordinates.Y - 1, maxY);
                    break;
            }

            return new CellCoordinates(x, y);
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
