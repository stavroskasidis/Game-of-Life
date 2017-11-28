using GameOfLife.Contracts;
using GameOfLife.Controls;
using GameOfLife.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfLife.Impementations
{
    public class UICellGridInitializer : IUICellGridInitializer
    {
        public void InitializeCellGridUI(Control container, CellGrid cellGrid)
        {
            for(var x=0; x < cellGrid.Rows; x++)
            {
                for(var y=0; y < cellGrid.Columns; y++)
                {
                    var cellViewer = new CellViewer(cellGrid.Cells[x, y]);
                    container.Controls.Add(cellViewer);
                    cellViewer.Top = x * cellViewer.Width;
                    cellViewer.Left = y * cellViewer.Height;
                }
            }
        }
    }
}
