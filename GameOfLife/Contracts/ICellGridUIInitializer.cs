using GameOfLife.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfLife.Contracts
{
    public interface IUICellGridInitializer
    {
        void InitializeCellGridUI(Control container, CellGrid cellGrid);
    }
}
