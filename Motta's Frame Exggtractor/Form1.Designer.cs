namespace Motta_s_Frame_Extractor
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
            this.EggxtractButton = new System.Windows.Forms.Button();
            this.OutputPathBox = new System.Windows.Forms.TextBox();
            this.EggBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ModeSelector = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.EggxtractionProgress = new System.Windows.Forms.ProgressBar();
            this.ProgressLabel = new System.Windows.Forms.Label();
            this.PercentLabel = new System.Windows.Forms.Label();
            this.EggBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // VideoPathBox
            // 
            this.VideoPathBox.Location = new System.Drawing.Point(12, 12);
            this.VideoPathBox.Name = "VideoPathBox";
            this.VideoPathBox.ReadOnly = true;
            this.VideoPathBox.Size = new System.Drawing.Size(363, 20);
            this.VideoPathBox.TabIndex = 0;
            this.VideoPathBox.Text = "No video selected";
            // 
            // SelectVideoButton
            // 
            this.SelectVideoButton.Location = new System.Drawing.Point(381, 10);
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
            this.TitleLabel.Location = new System.Drawing.Point(19, 24);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(36, 13);
            this.TitleLabel.TabIndex = 2;
            this.TitleLabel.Text = "Title : ";
            // 
            // DurationLabel
            // 
            this.DurationLabel.AutoSize = true;
            this.DurationLabel.Location = new System.Drawing.Point(19, 45);
            this.DurationLabel.Name = "DurationLabel";
            this.DurationLabel.Size = new System.Drawing.Size(53, 13);
            this.DurationLabel.TabIndex = 3;
            this.DurationLabel.Text = "Duration :";
            // 
            // FrameRateLabel
            // 
            this.FrameRateLabel.AutoSize = true;
            this.FrameRateLabel.Location = new System.Drawing.Point(19, 66);
            this.FrameRateLabel.Name = "FrameRateLabel";
            this.FrameRateLabel.Size = new System.Drawing.Size(68, 13);
            this.FrameRateLabel.TabIndex = 4;
            this.FrameRateLabel.Text = "Frame Rate :";
            // 
            // ExpectedFramesLabel
            // 
            this.ExpectedFramesLabel.AutoSize = true;
            this.ExpectedFramesLabel.Location = new System.Drawing.Point(19, 86);
            this.ExpectedFramesLabel.Name = "ExpectedFramesLabel";
            this.ExpectedFramesLabel.Size = new System.Drawing.Size(95, 13);
            this.ExpectedFramesLabel.TabIndex = 5;
            this.ExpectedFramesLabel.Text = "Expected Frames :";
            // 
            // EggxtractButton
            // 
            this.EggxtractButton.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EggxtractButton.Location = new System.Drawing.Point(344, 127);
            this.EggxtractButton.Name = "EggxtractButton";
            this.EggxtractButton.Size = new System.Drawing.Size(111, 25);
            this.EggxtractButton.TabIndex = 7;
            this.EggxtractButton.Text = "Eggxtract!";
            this.EggxtractButton.UseVisualStyleBackColor = true;
            this.EggxtractButton.Click += new System.EventHandler(this.EggxtractButton_Click);
            // 
            // OutputPathBox
            // 
            this.OutputPathBox.Location = new System.Drawing.Point(13, 130);
            this.OutputPathBox.Name = "OutputPathBox";
            this.OutputPathBox.ReadOnly = true;
            this.OutputPathBox.Size = new System.Drawing.Size(325, 20);
            this.OutputPathBox.TabIndex = 6;
            // 
            // EggBox
            // 
            this.EggBox.Controls.Add(this.label1);
            this.EggBox.Controls.Add(this.ModeSelector);
            this.EggBox.Controls.Add(this.label5);
            this.EggBox.Controls.Add(this.OutputPathBox);
            this.EggBox.Controls.Add(this.TitleLabel);
            this.EggBox.Controls.Add(this.EggxtractButton);
            this.EggBox.Controls.Add(this.DurationLabel);
            this.EggBox.Controls.Add(this.FrameRateLabel);
            this.EggBox.Controls.Add(this.ExpectedFramesLabel);
            this.EggBox.Enabled = false;
            this.EggBox.Location = new System.Drawing.Point(12, 40);
            this.EggBox.Name = "EggBox";
            this.EggBox.Size = new System.Drawing.Size(467, 161);
            this.EggBox.TabIndex = 8;
            this.EggBox.TabStop = false;
            this.EggBox.Text = "Video Details";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(344, 84);
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
            this.ModeSelector.Location = new System.Drawing.Point(345, 100);
            this.ModeSelector.Name = "ModeSelector";
            this.ModeSelector.Size = new System.Drawing.Size(110, 21);
            this.ModeSelector.TabIndex = 9;
            this.ModeSelector.SelectedIndexChanged += new System.EventHandler(this.ModeSelector_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Output Folder: ";
            // 
            // EggxtractionProgress
            // 
            this.EggxtractionProgress.Location = new System.Drawing.Point(1, 221);
            this.EggxtractionProgress.Name = "EggxtractionProgress";
            this.EggxtractionProgress.Size = new System.Drawing.Size(489, 15);
            this.EggxtractionProgress.TabIndex = 9;
            // 
            // ProgressLabel
            // 
            this.ProgressLabel.AutoSize = true;
            this.ProgressLabel.Location = new System.Drawing.Point(2, 205);
            this.ProgressLabel.Name = "ProgressLabel";
            this.ProgressLabel.Size = new System.Drawing.Size(0, 13);
            this.ProgressLabel.TabIndex = 9;
            // 
            // PercentLabel
            // 
            this.PercentLabel.AutoSize = true;
            this.PercentLabel.Location = new System.Drawing.Point(459, 205);
            this.PercentLabel.Name = "PercentLabel";
            this.PercentLabel.Size = new System.Drawing.Size(0, 13);
            this.PercentLabel.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 236);
            this.Controls.Add(this.PercentLabel);
            this.Controls.Add(this.ProgressLabel);
            this.Controls.Add(this.EggxtractionProgress);
            this.Controls.Add(this.EggBox);
            this.Controls.Add(this.SelectVideoButton);
            this.Controls.Add(this.VideoPathBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frame Eggxtractor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.EggBox.ResumeLayout(false);
            this.EggBox.PerformLayout();
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
        private System.Windows.Forms.Button EggxtractButton;
        private System.Windows.Forms.TextBox OutputPathBox;
        private System.Windows.Forms.GroupBox EggBox;
        private System.Windows.Forms.ProgressBar EggxtractionProgress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label ProgressLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ModeSelector;
        private System.Windows.Forms.Label PercentLabel;
    }
}

