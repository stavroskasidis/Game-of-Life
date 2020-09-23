using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameOfLife.Engine.Model;
using GameOfLife.Engine.Contracts;

namespace GameOfLife.Engine.Implementations
{
    public class GenerationCloner : IGenerationCloner
    {
        public Generation Clone(Generation generation)
        {
            var clone = new Generation(generation.Rows, generation.Columns);
            foreach (var cell in generation.Cells)
            {
                var cloneCell = clone.Cells[cell.Coordinates.Row, cell.Coordinates.Column];
                cloneCell.IsAlive = cell.IsAlive;
            }
            return clone;
        }
    }
}
