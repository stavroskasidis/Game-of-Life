using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameOfLife.Model;

namespace GameOfLife.Controls
{
    public partial class CellViewer : UserControl
    {
        public Cell Cell { get; private set; }
        public bool AllowUserStateChange { get; set; } = true;

        public CellViewer(Cell cell)
        {
            Cell = cell;
            InitializeComponent();
        }

        public void UpdateCell(Cell newCell)
        {
            var stateChanged = newCell.IsAlive != Cell.IsAlive;
            Cell = newCell;
            if (stateChanged)
            {
                this.Refresh();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            this.BackColor = Cell.IsAlive ? Color.Black : Color.White;
            base.OnPaint(e);
        }

        protected override void OnClick(EventArgs e)
        {
            if (AllowUserStateChange)
            {
                Cell.IsAlive = !Cell.IsAlive;
                this.Refresh();
            }

            base.OnClick(e);
        }
    }
}
