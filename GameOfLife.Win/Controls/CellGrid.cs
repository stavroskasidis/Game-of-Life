﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameOfLife.Engine.Model;
using System.Drawing.Drawing2D;

namespace GameOfLife.Controls
{
    public partial class CellGrid : UserControl
    {
        private Generation _generation;
        private int _cellSize;
        public bool AllowClick { get; set; } = true;

        public CellGrid(Generation generation, int cellSize)
        {
            InitializeComponent();
            _generation = generation;
            _cellSize = cellSize;
            this.Width = _generation.Columns * _cellSize;
            this.Height = _generation.Rows * _cellSize;
            DoubleBuffered = true;
        }

        public void UpdateCellGrid(Generation cellGrid)
        {
            _generation = cellGrid;
            this.Invalidate();
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            if (AllowClick && e.Button == MouseButtons.Left)
            {
                var cell = _generation.Cells[e.Y / _cellSize, e.X / _cellSize];
                cell.IsAlive = !cell.IsAlive;
                this.Invalidate();
            }

            base.OnMouseClick(e);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            using (var pen = new Pen(Color.Black, 1))
            using (var brush = new SolidBrush(Color.Black))
            {
                pen.Alignment = PenAlignment.Inset;

                foreach (var cell in _generation.Cells)
                {
                    var row = cell.Coordinates.Row;
                    var column = cell.Coordinates.Column;
                    if (cell.IsAlive)
                    {
                        e.Graphics.FillRectangle(brush, column * _cellSize, row * _cellSize, _cellSize, _cellSize);
                    }
                    else
                    {
                        e.Graphics.DrawRectangle(pen, column * _cellSize, row * _cellSize, _cellSize, _cellSize);

                    }
                }
            }

            base.OnPaint(e);
        }
    }
}
