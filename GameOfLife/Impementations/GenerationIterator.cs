using GameOfLife.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameOfLife.Model;

namespace GameOfLife.Impementations
{
    public class GenerationIterator : IGenerationIterator
    {
        private ICellStateCalculator _cellStateCalculator;

        public GenerationIterator(ICellStateCalculator cellStateCalculator)
        {
            _cellStateCalculator = cellStateCalculator;
        }

        public CellGrid NextGeneration(CellGrid cellGrid)
        {
            var nextGenerationGrid = cellGrid.Clone();
            for (var x = 0; x < cellGrid.Rows; x++)
            {
                for(var y=0; y < cellGrid.Columns; y++)
                {
                    var currentGenerationCell = cellGrid.Cells[x, y];
                    var nextGenerationCell = nextGenerationGrid.Cells[x, y];

                    nextGenerationCell.IsAlive = _cellStateCalculator.CalculateCellStateForNextGen(currentGenerationCell, cellGrid);
                    //nextGenerationCell.StateChangedFromPreviousGen = currentGenerationCell.IsAlive != nextGenerationCell.IsAlive;
                }
            }

            return nextGenerationGrid;
        }
    }
}
