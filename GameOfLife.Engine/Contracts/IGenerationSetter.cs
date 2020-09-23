using GameOfLife.Engine.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfLife.Engine.Contracts
{
    public interface IGenerationSetter
    {
        void Randomize(Generation generation);
        void Clear(Generation generation);
    }
}
