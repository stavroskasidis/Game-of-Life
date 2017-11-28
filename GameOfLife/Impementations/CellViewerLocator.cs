using GameOfLife.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameOfLife.Controls;
using GameOfLife.Model;
using System.Windows.Forms;

namespace GameOfLife.Impementations
{
    public class CellViewerLocator : ICellViewerLocator
    {
        public CellViewer FindCellViewer(Control container, CellCoordinates coordinates)
        {
            return container.Controls.Cast<CellViewer>().First(x => x.Cell.Coordinates.X == coordinates.X &&
                                                                    x.Cell.Coordinates.Y == coordinates.Y);
        }
    }
}
