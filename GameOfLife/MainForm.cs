using GameOfLife.Contracts;
using GameOfLife.Controls;
using GameOfLife.Impementations;
using GameOfLife.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfLife
{
    public partial class MainForm : Form
    {
        private CellGrid CurrentCellGrid = new CellGrid(34, 49);
        private IGenerationIterator _generationIterator;
        private ICellRenderer _cellRenderer;
        private ICellViewerLocator _cellViewerLocator;
        private volatile bool _isRunning = false;
        private Random _random = new Random();

        public MainForm()
        {
            InitializeComponent();
            var cellGridUIInitializer = new UICellGridInitializer();
            cellGridUIInitializer.InitializeCellGridUI(this.CellContainer, this.CurrentCellGrid);

            _generationIterator = new GenerationIterator(new CellStateCalculator(new CellNeighbourResolver()));
            _cellViewerLocator = new CellViewerLocator();
            _cellRenderer = new CellRenderer(_cellViewerLocator);
        }

        private void SetCellsClickable(bool areClickable)
        {
            foreach (var viewer in this.CellContainer.Controls.Cast<CellViewer>())
            {
                viewer.AllowUserStateChange = areClickable;
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (!_isRunning)
            {
                StartButton.Text = "Stop";
                RandomizeButton.Enabled = false;
                ClearButton.Enabled = false;
                _isRunning = true;
                SetCellsClickable(false);

                Task.Run(() =>
                {
                    while (_isRunning)
                    {
                        var nextGenGrid = _generationIterator.NextGeneration(CurrentCellGrid);
                        //var changedCells = nextGenGrid.Cells.Cast<Cell>().Where(x => x.StateChangedFromPreviousGen);
                        this.Invoke((MethodInvoker)delegate
                        {
                            foreach (var cell in nextGenGrid.Cells.Cast<Cell>())
                            {
                                _cellRenderer.UpdateCellViewer(CellContainer, cell);
                            }
                        });

                        CurrentCellGrid = nextGenGrid;
                        Application.DoEvents();
                    }
                });
            }
            else
            {
                StartButton.Text = "Start";
                _isRunning = false;
                RandomizeButton.Enabled = true;
                ClearButton.Enabled = true;
                SetCellsClickable(true);
            }
        }

        private void RandomizeButton_Click(object sender, EventArgs e)
        {
            for (var x = 0; x < CurrentCellGrid.Rows; x++)
            {
                for (var y = 0; y < CurrentCellGrid.Columns; y++)
                {
                    var cell = CurrentCellGrid.Cells[x, y];
                    var newState = _random.Next(2) == 1;
                    var stateChanged = cell.IsAlive != newState;
                    cell.IsAlive = newState;
                    if (stateChanged)
                    {
                        var cellViewer = _cellViewerLocator.FindCellViewer(CellContainer, cell.Coordinates);
                        cellViewer.Refresh();
                    }
                }
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            for (var x = 0; x < CurrentCellGrid.Rows; x++)
            {
                for (var y = 0; y < CurrentCellGrid.Columns; y++)
                {
                    var cell = CurrentCellGrid.Cells[x, y];
                    var newState = false;
                    var stateChanged = cell.IsAlive != newState;
                    cell.IsAlive = newState;
                    if (stateChanged)
                    {
                        var cellViewer = _cellViewerLocator.FindCellViewer(CellContainer, cell.Coordinates);
                        cellViewer.Refresh();
                    }
                }
            }
        }
    }
}
