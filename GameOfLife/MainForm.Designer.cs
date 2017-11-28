namespace GameOfLife
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CellContainer = new System.Windows.Forms.Panel();
            this.StartButton = new System.Windows.Forms.Button();
            this.RandomizeButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CellContainer
            // 
            this.CellContainer.Location = new System.Drawing.Point(12, 37);
            this.CellContainer.Name = "CellContainer";
            this.CellContainer.Size = new System.Drawing.Size(980, 680);
            this.CellContainer.TabIndex = 0;
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(12, 8);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // RandomizeButton
            // 
            this.RandomizeButton.Location = new System.Drawing.Point(93, 8);
            this.RandomizeButton.Name = "RandomizeButton";
            this.RandomizeButton.Size = new System.Drawing.Size(75, 23);
            this.RandomizeButton.TabIndex = 2;
            this.RandomizeButton.Text = "Randomize";
            this.RandomizeButton.UseVisualStyleBackColor = true;
            this.RandomizeButton.Click += new System.EventHandler(this.RandomizeButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(174, 8);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 3;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.RandomizeButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.CellContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game of Life";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel CellContainer;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button RandomizeButton;
        private System.Windows.Forms.Button ClearButton;
    }
}

