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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfLife
{
    public partial class MainForm : Form
    {
        private readonly int _cellSize = 20;
        private readonly int _rows = 34;
        private readonly int _columns = 49;
        private readonly int _fps = 15;
        private Generation _currentGeneration;
        private IGenerationIterator _generationIterator;
        private volatile bool _isRunning = false;
        private Random _random = new Random();
        private CellGrid _cellGridViewer;
        private StackWithLimit<Generation> _generationHistory = new StackWithLimit<Generation>(1000);

        public MainForm()
        {
            InitializeComponent();
            
            _currentGeneration = new Generation(_rows, _columns);
            _cellGridViewer = new CellGrid(_currentGeneration, _cellSize);
            this.Controls.Add(_cellGridViewer);
            this.PreviousGenerationButton.Enabled = false;

            this.AutoTimer.Interval = 1000 / _fps;
            _cellGridViewer.Location = new Point(12, 32);
            _generationIterator = new GenerationIterator(new CellStateCalculator(new CellNeighbourResolver()));
        }

        private void SetUI(bool isRunning)
        {
            StartButton.Text = isRunning ? "Stop" : "Auto";
            RandomizeButton.Enabled = !isRunning;
            ClearButton.Enabled = !isRunning;
            NextGenerationButton.Enabled = !isRunning;
            PreviousGenerationButton.Enabled = !isRunning && _generationHistory.Count > 0;
            _cellGridViewer.AllowClick = !isRunning;
        }

        private void NextGeneration()
        {
            var nextGenGrid = _generationIterator.NextGeneration(_currentGeneration);
            this.Invoke((MethodInvoker)delegate
            {
                _cellGridViewer.UpdateCellGrid(nextGenGrid);
            });

            _generationHistory.Push(_currentGeneration);
            _currentGeneration = nextGenGrid;
        }

        private void PreviousGeneration()
        {
            var previousGen = _generationHistory.Pop();
            if(previousGen != null)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    _cellGridViewer.UpdateCellGrid(previousGen);
                });
                _currentGeneration = previousGen;
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            _isRunning = !_isRunning;
            SetUI(_isRunning);
            if (_isRunning)
            {
                AutoTimer.Start();
            }
            else
            {
                AutoTimer.Stop();
            }
        }

        private void RandomizeButton_Click(object sender, EventArgs e)
        {
            foreach (var cell in _currentGeneration.Cells.Cast<Cell>())
            {
                cell.IsAlive = _random.Next(2) == 1;
            }

            _cellGridViewer.Invalidate();
            PreviousGenerationButton.Enabled = false;
            _generationHistory.Clear();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            foreach (var cell in _currentGeneration.Cells.Cast<Cell>())
            {
                cell.IsAlive = false;
            }

            _cellGridViewer.Invalidate();
            PreviousGenerationButton.Enabled = false;
            _generationHistory.Clear();
        }

        private void NextGenerationButton_Click(object sender, EventArgs e)
        {
            NextGeneration();
            PreviousGenerationButton.Enabled = _generationHistory.Count > 0;
        }

        private void PreviousGenerationButton_Click(object sender, EventArgs e)
        {
            PreviousGeneration();
            PreviousGenerationButton.Enabled = _generationHistory.Count > 0;
        }

        private void AutoTimer_Tick(object sender, EventArgs e)
        {
            NextGeneration();
        }
    }
}
