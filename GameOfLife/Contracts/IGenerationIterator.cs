using GameOfLife.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife.Contracts
{
    public interface IGenerationIterator
    {
        Generation NextGeneration(Generation generation);
    }
}
