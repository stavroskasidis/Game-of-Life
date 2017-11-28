using GameOfLife.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameOfLife.Model;

namespace GameOfLife.Impementations
{
    public class CellStateCalculator : ICellStateCalculator
    {
        private ICellNeighbourResolver _cellNeighbourResolver;

        public CellStateCalculator(ICellNeighbourResolver cellNeighbourResolver)
        {
            _cellNeighbourResolver = cellNeighbourResolver;
        }

        public bool CalculateCellStateForNextGen(Cell cell, CellGrid grid)
        {
            var currentCellCoordinates = cell.Coordinates;
            var neighbourCells = new List<Cell>();
            foreach (var position in Enum.GetValues(typeof(NeighbourPosition)).Cast<NeighbourPosition>())
            {
                var coordinates = _cellNeighbourResolver.GetNeighbourCoordinates(cell, grid, position);
                neighbourCells.Add(grid.Cells[coordinates.X, coordinates.Y]);
            }

            var aliveNeighboursCount = neighbourCells.Count(x => x.IsAlive);
            if (cell.IsAlive && aliveNeighboursCount < 2)
            {
                return false;
            }
            else if(cell.IsAlive && (aliveNeighboursCount == 3 || aliveNeighboursCount == 2))
            {
                return true;
            }
            else if (cell.IsAlive && aliveNeighboursCount > 3)
            {
                return false;
            }
            else
            {
                return aliveNeighboursCount == 3 ? true : false;
            }
        }
    }
}
