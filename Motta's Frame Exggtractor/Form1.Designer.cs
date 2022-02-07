namespace Frame_Extractor
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.VideoPathBox = new System.Windows.Forms.TextBox();
            this.SelectVideoButton = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.DurationLabel = new System.Windows.Forms.Label();
            this.FrameRateLabel = new System.Windows.Forms.Label();
            this.ExpectedFramesLabel = new System.Windows.Forms.Label();
            this.ExtractButton = new System.Windows.Forms.Button();
            this.OutputPathBox = new System.Windows.Forms.TextBox();
            this.Box = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ModeSelector = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ExtractionProgress = new System.Windows.Forms.ProgressBar();
            this.ProgressLabel = new System.Windows.Forms.Label();
            this.PercentLabel = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SelectOutputFolderButton = new System.Windows.Forms.Button();
            this.Box.SuspendLayout();
            this.SuspendLayout();
            // 
            // VideoPathBox
            // 
            this.VideoPathBox.Location = new System.Drawing.Point(12, 11);
            this.VideoPathBox.Name = "VideoPathBox";
            this.VideoPathBox.ReadOnly = true;
            this.VideoPathBox.Size = new System.Drawing.Size(363, 20);
            this.VideoPathBox.TabIndex = 0;
            this.VideoPathBox.Text = "No video selected";
            // 
            // SelectVideoButton
            // 
            this.SelectVideoButton.Location = new System.Drawing.Point(381, 9);
            this.SelectVideoButton.Name = "SelectVideoButton";
            this.SelectVideoButton.Size = new System.Drawing.Size(98, 23);
            this.SelectVideoButton.TabIndex = 1;
            this.SelectVideoButton.Text = "Select Video";
            this.SelectVideoButton.UseVisualStyleBackColor = true;
            this.SelectVideoButton.Click += new System.EventHandler(this.SelectVideoButton_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(12, 23);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(36, 13);
            this.TitleLabel.TabIndex = 2;
            this.TitleLabel.Text = "Title : ";
            // 
            // DurationLabel
            // 
            this.DurationLabel.AutoSize = true;
            this.DurationLabel.Location = new System.Drawing.Point(12, 44);
            this.DurationLabel.Name = "DurationLabel";
            this.DurationLabel.Size = new System.Drawing.Size(53, 13);
            this.DurationLabel.TabIndex = 3;
            this.DurationLabel.Text = "Duration :";
            // 
            // FrameRateLabel
            // 
            this.FrameRateLabel.AutoSize = true;
            this.FrameRateLabel.Location = new System.Drawing.Point(12, 65);
            this.FrameRateLabel.Name = "FrameRateLabel";
            this.FrameRateLabel.Size = new System.Drawing.Size(68, 13);
            this.FrameRateLabel.TabIndex = 4;
            this.FrameRateLabel.Text = "Frame Rate :";
            // 
            // ExpectedFramesLabel
            // 
            this.ExpectedFramesLabel.AutoSize = true;
            this.ExpectedFramesLabel.Location = new System.Drawing.Point(12, 85);
            this.ExpectedFramesLabel.Name = "ExpectedFramesLabel";
            this.ExpectedFramesLabel.Size = new System.Drawing.Size(95, 13);
            this.ExpectedFramesLabel.TabIndex = 5;
            this.ExpectedFramesLabel.Text = "Expected Frames :";
            // 
            // ExtractButton
            // 
            this.ExtractButton.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExtractButton.Location = new System.Drawing.Point(177, 178);
            this.ExtractButton.Name = "ExtractButton";
            this.ExtractButton.Size = new System.Drawing.Size(136, 25);
            this.ExtractButton.TabIndex = 7;
            this.ExtractButton.Text = "Extract!";
            this.ExtractButton.UseVisualStyleBackColor = true;
            this.ExtractButton.Click += new System.EventHandler(this.ExtractButton_Click);
            // 
            // OutputPathBox
            // 
            this.OutputPathBox.Location = new System.Drawing.Point(12, 132);
            this.OutputPathBox.Name = "OutputPathBox";
            this.OutputPathBox.ReadOnly = true;
            this.OutputPathBox.Size = new System.Drawing.Size(339, 20);
            this.OutputPathBox.TabIndex = 6;
            // 
            // Box
            // 
            this.Box.Controls.Add(this.SelectOutputFolderButton);
            this.Box.Controls.Add(this.CancelButton);
            this.Box.Controls.Add(this.label1);
            this.Box.Controls.Add(this.ModeSelector);
            this.Box.Controls.Add(this.label5);
            this.Box.Controls.Add(this.OutputPathBox);
            this.Box.Controls.Add(this.TitleLabel);
            this.Box.Controls.Add(this.ExtractButton);
            this.Box.Controls.Add(this.DurationLabel);
            this.Box.Controls.Add(this.FrameRateLabel);
            this.Box.Controls.Add(this.ExpectedFramesLabel);
            this.Box.Enabled = false;
            this.Box.Location = new System.Drawing.Point(12, 40);
            this.Box.Name = "Box";
            this.Box.Size = new System.Drawing.Size(467, 215);
            this.Box.TabIndex = 8;
            this.Box.TabStop = false;
            this.Box.Text = "Video Details";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Extract:";
            // 
            // ModeSelector
            // 
            this.ModeSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ModeSelector.FormattingEnabled = true;
            this.ModeSelector.Items.AddRange(new object[] {
            "All possible frames",
            "Frames per second"});
            this.ModeSelector.Location = new System.Drawing.Point(13, 181);
            this.ModeSelector.Name = "ModeSelector";
            this.ModeSelector.Size = new System.Drawing.Size(157, 21);
            this.ModeSelector.TabIndex = 9;
            this.ModeSelector.SelectedIndexChanged += new System.EventHandler(this.ModeSelector_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Output Folder: ";
            // 
            // ExtractionProgress
            // 
            this.ExtractionProgress.Location = new System.Drawing.Point(-2, 278);
            this.ExtractionProgress.Name = "ExtractionProgress";
            this.ExtractionProgress.Size = new System.Drawing.Size(495, 15);
            this.ExtractionProgress.TabIndex = 9;
            // 
            // ProgressLabel
            // 
            this.ProgressLabel.AutoSize = true;
            this.ProgressLabel.Location = new System.Drawing.Point(10, 260);
            this.ProgressLabel.Name = "ProgressLabel";
            this.ProgressLabel.Size = new System.Drawing.Size(0, 13);
            this.ProgressLabel.TabIndex = 9;
            // 
            // PercentLabel
            // 
            this.PercentLabel.AutoSize = true;
            this.PercentLabel.Location = new System.Drawing.Point(451, 260);
            this.PercentLabel.Name = "PercentLabel";
            this.PercentLabel.Size = new System.Drawing.Size(0, 13);
            this.PercentLabel.TabIndex = 11;
            // 
            // CancelButton
            // 
            this.CancelButton.Enabled = false;
            this.CancelButton.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(319, 178);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(136, 25);
            this.CancelButton.TabIndex = 11;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SelectOutputFolderButton
            // 
            this.SelectOutputFolderButton.Location = new System.Drawing.Point(357, 130);
            this.SelectOutputFolderButton.Name = "SelectOutputFolderButton";
            this.SelectOutputFolderButton.Size = new System.Drawing.Size(98, 25);
            this.SelectOutputFolderButton.TabIndex = 12;
            this.SelectOutputFolderButton.Text = "Select Folder";
            this.SelectOutputFolderButton.UseVisualStyleBackColor = true;
            this.SelectOutputFolderButton.Click += new System.EventHandler(this.SelectOutputFolderButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 293);
            this.Controls.Add(this.PercentLabel);
            this.Controls.Add(this.ProgressLabel);
            this.Controls.Add(this.ExtractionProgress);
            this.Controls.Add(this.Box);
            this.Controls.Add(this.SelectVideoButton);
            this.Controls.Add(this.VideoPathBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frame Extractor";
            this.Box.ResumeLayout(false);
            this.Box.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox VideoPathBox;
        private System.Windows.Forms.Button SelectVideoButton;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label DurationLabel;
        private System.Windows.Forms.Label FrameRateLabel;
        private System.Windows.Forms.Label ExpectedFramesLabel;
        private System.Windows.Forms.Button ExtractButton;
        private System.Windows.Forms.TextBox OutputPathBox;
        private System.Windows.Forms.GroupBox Box;
        private System.Windows.Forms.ProgressBar ExtractionProgress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label ProgressLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ModeSelector;
        private System.Windows.Forms.Label PercentLabel;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SelectOutputFolderButton;
    }
}

