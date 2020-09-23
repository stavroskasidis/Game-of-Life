using GameOfLife.Engine.Contracts;
using GameOfLife.Engine.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfLife.Engine.Implementations
{
    public class GenerationSetter : IGenerationSetter
    {
        private Random _random = new Random();

        public void Clear(Generation generation)
        {
            foreach (var cell in generation.Cells)
            {
                cell.IsAlive = false;
            }
        }

        public void Randomize(Generation generation)
        {
            foreach (var cell in generation.Cells)
            {
                cell.IsAlive = _random.Next(2) == 1;
            }

        }
    }
}
