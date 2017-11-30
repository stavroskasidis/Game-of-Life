using GameOfLife.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife.Contracts
{
    public interface ICellNeighbourResolver
    {
        CellCoordinates GetNeighbourCoordinates(Cell cell, Generation generation ,NeighbourPosition position);
    }
}
