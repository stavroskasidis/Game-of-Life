using GameOfLife.Engine.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife.Engine.Contracts
{
    public interface ICellStateCalculator
    {
        bool CalculateCellStateForNextGen(Cell cell, Generation generation);
    }
}
