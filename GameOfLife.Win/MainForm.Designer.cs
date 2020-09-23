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
            this.components = new System.ComponentModel.Container();
            this.StartButton = new System.Windows.Forms.Button();
            this.RandomizeButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.NextGenerationButton = new System.Windows.Forms.Button();
            this.PreviousGenerationButton = new System.Windows.Forms.Button();
            this.AutoTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(12, 8);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "Auto";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // RandomizeButton
            // 
            this.RandomizeButton.Location = new System.Drawing.Point(808, 8);
            this.RandomizeButton.Name = "RandomizeButton";
            this.RandomizeButton.Size = new System.Drawing.Size(75, 23);
            this.RandomizeButton.TabIndex = 2;
            this.RandomizeButton.Text = "Randomize";
            this.RandomizeButton.UseVisualStyleBackColor = true;
            this.RandomizeButton.Click += new System.EventHandler(this.RandomizeButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(889, 8);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 3;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // NextGenerationButton
            // 
            this.NextGenerationButton.Location = new System.Drawing.Point(203, 8);
            this.NextGenerationButton.Name = "NextGenerationButton";
            this.NextGenerationButton.Size = new System.Drawing.Size(79, 23);
            this.NextGenerationButton.TabIndex = 4;
            this.NextGenerationButton.Text = "Next Gen";
            this.NextGenerationButton.UseVisualStyleBackColor = true;
            this.NextGenerationButton.Click += new System.EventHandler(this.NextGenerationButton_Click);
            // 
            // PreviousGenerationButton
            // 
            this.PreviousGenerationButton.Location = new System.Drawing.Point(118, 8);
            this.PreviousGenerationButton.Name = "PreviousGenerationButton";
            this.PreviousGenerationButton.Size = new System.Drawing.Size(79, 23);
            this.PreviousGenerationButton.TabIndex = 5;
            this.PreviousGenerationButton.Text = "Previous Gen";
            this.PreviousGenerationButton.UseVisualStyleBackColor = true;
            this.PreviousGenerationButton.Click += new System.EventHandler(this.PreviousGenerationButton_Click);
            // 
            // AutoTimer
            // 
            this.AutoTimer.Tick += new System.EventHandler(this.AutoTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.PreviousGenerationButton);
            this.Controls.Add(this.NextGenerationButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.RandomizeButton);
            this.Controls.Add(this.StartButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game of Life";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button RandomizeButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button NextGenerationButton;
        private System.Windows.Forms.Button PreviousGenerationButton;
        private System.Windows.Forms.Timer AutoTimer;
    }
}

