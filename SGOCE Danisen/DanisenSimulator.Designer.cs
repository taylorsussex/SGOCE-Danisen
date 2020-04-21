namespace SGOCE_Danisen
{
    partial class DanisenSimulator
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
            this.InputPath = new System.Windows.Forms.TextBox();
            this.OutputPath1 = new System.Windows.Forms.TextBox();
            this.BrowseInput = new System.Windows.Forms.Button();
            this.BrowseOutput1 = new System.Windows.Forms.Button();
            this.Simulate = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.OutputPath2 = new System.Windows.Forms.TextBox();
            this.BrowseOutput2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.HistoryPath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BrowseHistory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InputPath
            // 
            this.InputPath.Location = new System.Drawing.Point(12, 35);
            this.InputPath.Name = "InputPath";
            this.InputPath.Size = new System.Drawing.Size(178, 20);
            this.InputPath.TabIndex = 0;
            // 
            // OutputPath1
            // 
            this.OutputPath1.Location = new System.Drawing.Point(12, 93);
            this.OutputPath1.Name = "OutputPath1";
            this.OutputPath1.Size = new System.Drawing.Size(178, 20);
            this.OutputPath1.TabIndex = 2;
            // 
            // BrowseInput
            // 
            this.BrowseInput.Location = new System.Drawing.Point(196, 32);
            this.BrowseInput.Name = "BrowseInput";
            this.BrowseInput.Size = new System.Drawing.Size(75, 23);
            this.BrowseInput.TabIndex = 1;
            this.BrowseInput.Text = "Browse";
            this.BrowseInput.UseVisualStyleBackColor = true;
            this.BrowseInput.Click += new System.EventHandler(this.BrowseInput_Click);
            // 
            // BrowseOutput1
            // 
            this.BrowseOutput1.Location = new System.Drawing.Point(196, 90);
            this.BrowseOutput1.Name = "BrowseOutput1";
            this.BrowseOutput1.Size = new System.Drawing.Size(75, 23);
            this.BrowseOutput1.TabIndex = 3;
            this.BrowseOutput1.Text = "Browse";
            this.BrowseOutput1.UseVisualStyleBackColor = true;
            this.BrowseOutput1.Click += new System.EventHandler(this.BrowseOutput1_Click);
            // 
            // Simulate
            // 
            this.Simulate.Location = new System.Drawing.Point(12, 247);
            this.Simulate.Name = "Simulate";
            this.Simulate.Size = new System.Drawing.Size(75, 23);
            this.Simulate.TabIndex = 8;
            this.Simulate.Text = "Simulate";
            this.Simulate.UseVisualStyleBackColor = true;
            this.Simulate.Click += new System.EventHandler(this.Simulate_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "csv files|*.csv";
            // 
            // OutputPath2
            // 
            this.OutputPath2.Location = new System.Drawing.Point(12, 148);
            this.OutputPath2.Name = "OutputPath2";
            this.OutputPath2.Size = new System.Drawing.Size(178, 20);
            this.OutputPath2.TabIndex = 4;
            // 
            // BrowseOutput2
            // 
            this.BrowseOutput2.Location = new System.Drawing.Point(197, 149);
            this.BrowseOutput2.Name = "BrowseOutput2";
            this.BrowseOutput2.Size = new System.Drawing.Size(75, 23);
            this.BrowseOutput2.TabIndex = 5;
            this.BrowseOutput2.Text = "Browse";
            this.BrowseOutput2.UseVisualStyleBackColor = true;
            this.BrowseOutput2.Click += new System.EventHandler(this.BrowseOutput2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Match spreadsheet input";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Match spreadsheet output";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ranking spreadsheet output";
            // 
            // HistoryPath
            // 
            this.HistoryPath.Location = new System.Drawing.Point(12, 206);
            this.HistoryPath.Name = "HistoryPath";
            this.HistoryPath.Size = new System.Drawing.Size(178, 20);
            this.HistoryPath.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Player history directory";
            // 
            // BrowseHistory
            // 
            this.BrowseHistory.Location = new System.Drawing.Point(196, 203);
            this.BrowseHistory.Name = "BrowseHistory";
            this.BrowseHistory.Size = new System.Drawing.Size(75, 23);
            this.BrowseHistory.TabIndex = 7;
            this.BrowseHistory.Text = "Browse";
            this.BrowseHistory.UseVisualStyleBackColor = true;
            this.BrowseHistory.Click += new System.EventHandler(this.BrowseHistory_Click);
            // 
            // DanisenSimulator
            // 
            this.AcceptButton = this.Simulate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 286);
            this.Controls.Add(this.BrowseHistory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BrowseOutput2);
            this.Controls.Add(this.Simulate);
            this.Controls.Add(this.BrowseOutput1);
            this.Controls.Add(this.BrowseInput);
            this.Controls.Add(this.OutputPath2);
            this.Controls.Add(this.OutputPath1);
            this.Controls.Add(this.HistoryPath);
            this.Controls.Add(this.InputPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DanisenSimulator";
            this.Text = "DanisenSimulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputPath;
        private System.Windows.Forms.TextBox OutputPath1;
        private System.Windows.Forms.Button BrowseInput;
        private System.Windows.Forms.Button BrowseOutput1;
        private System.Windows.Forms.Button Simulate;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox OutputPath2;
        private System.Windows.Forms.Button BrowseOutput2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.TextBox HistoryPath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BrowseHistory;
    }
}

