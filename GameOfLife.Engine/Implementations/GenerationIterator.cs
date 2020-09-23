using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameOfLife.Engine.Contracts;
using GameOfLife.Engine.Model;

namespace GameOfLife.Engine.Implementations
{
    public class GenerationIterator : IGenerationIterator
    {
        private ICellStateCalculator _cellStateCalculator;
        private IGenerationCloner _generationCloner;

        public GenerationIterator(ICellStateCalculator cellStateCalculator, IGenerationCloner generationCloner)
        {
            _cellStateCalculator = cellStateCalculator;
            _generationCloner = generationCloner;
        }

        public Generation NextGeneration(Generation generation)
        {
            var nextGeneration = _generationCloner.Clone(generation);
            foreach (var cell in generation.Cells)
            {
                var nextGenerationCell = nextGeneration.Cells[cell.Coordinates.Row, cell.Coordinates.Column];
                nextGenerationCell.IsAlive = _cellStateCalculator.CalculateCellStateForNextGen(cell, generation);
            }

            return nextGeneration;
        }
    }
}
