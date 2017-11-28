using GameOfLife.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameOfLife.Model;
using System.Windows.Forms;

namespace GameOfLife.Impementations
{
    public class CellRenderer : ICellRenderer
    {
        private readonly ICellViewerLocator _cellViewerLocator;

        public CellRenderer(ICellViewerLocator cellViewerLocator)
        {
            _cellViewerLocator = cellViewerLocator;
        }

        public void UpdateCellViewer(Control container, Cell cell)
        {
            var cellViewer = _cellViewerLocator.FindCellViewer(container, cell.Coordinates);
            cellViewer.UpdateCell(cell);
        }
    }
}
