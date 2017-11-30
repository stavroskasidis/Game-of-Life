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

        public Generation NextGeneration(Generation generation)
        {
            var nextGenerationGrid = generation.Clone();
            foreach (var cell in generation.Cells)
            {
                var nextGenerationCell = nextGenerationGrid.Cells[cell.Coordinates.Row, cell.Coordinates.Column];
                nextGenerationCell.IsAlive = _cellStateCalculator.CalculateCellStateForNextGen(cell, generation);
            }

            return nextGenerationGrid;
        }
    }
}
