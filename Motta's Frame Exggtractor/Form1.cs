using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

using MediaToolkit;
using MediaToolkit.Model;
using MediaToolkit.Options;

namespace Frame_Extractor
{
    public partial class Form1 : Form
    {
        string OutputPath, InputPath;
        double TotalFrames, Period;
        bool CancelSignal;

        MediaFile Mp4Media;

        public Form1()
        {
            InitializeComponent();
            CancelSignal = false;
        }

        private void SelectVideoButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog()
            {
                FileName = "Select an MP4 file",
                Filter = "Video files (*.mp4)|*.mp4",
                Title = "Open MP4 File"
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                InputPath = openFileDialog1.FileName;
                OutputPath = Directory.GetParent(InputPath) + "\\Extracted - " + Path.GetFileNameWithoutExtension(InputPath);
                VideoPathBox.Text = InputPath;
                OutputPathBox.Text = OutputPath;

                Mp4Media = new MediaFile { Filename = InputPath };

                using (var engine = new Engine())
                {
                    engine.GetMetadata(Mp4Media);
                }

                TotalFrames = Mp4Media.Metadata.Duration.TotalSeconds * Mp4Media.Metadata.VideoData.Fps;
                ExtractionProgress.Maximum = (int)TotalFrames;
                ExtractionProgress.Value = 0;

                TitleLabel.Text = "Title : " + Path.GetFileNameWithoutExtension(InputPath);
                FrameRateLabel.Text = "Frame Rate : " + Mp4Media.Metadata.VideoData.Fps.ToString() + " FPS";
                DurationLabel.Text = "Duration : " + Mp4Media.Metadata.Duration.ToString();
                ExpectedFramesLabel.Text = "Expected Frames : " + ExtractionProgress.Maximum.ToString();

                ModeSelector.SelectedIndex = 0;
                Box.Enabled = true;
            }
        }

        private async void ExtractButton_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory(OutputPath);

            VideoPathBox.Enabled = false;
            SelectVideoButton.Enabled = false;
            CancelButton.Enabled = true;
            ExtractButton.Enabled = false;
            OutputPathBox.Enabled = false;
            ModeSelector.Enabled = false;

            await StartExtraction();

            if(CancelSignal)
            {
                CancelSignal = false;
                MessageBox.Show("Operation was aborted.", "Aborted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult r = MessageBox.Show(ExtractionProgress.Maximum.ToString() + " Frames were extracted. Open Output folder?", "Operation Completed Successfully", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (r == DialogResult.Yes)
                    System.Diagnostics.Process.Start(OutputPath);
            }

            ProgressLabel.Text = "";
            PercentLabel.Text = "";
            VideoPathBox.Enabled = true;
            SelectVideoButton.Enabled = true;
            CancelButton.Enabled = false;
            ExtractButton.Enabled = true;
            OutputPathBox.Enabled = true;
            ModeSelector.Enabled = true;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Sure to abort?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (r == DialogResult.Yes)
                CancelSignal = true;
        }

        private async Task StartExtraction()
        {
            await Task.Run(delegate
            {
                using (var engine = new Engine())
                {
                    double seeker = 0;

                    for (int i = 0; i < ExtractionProgress.Maximum; i++, seeker += Period)
                    {
                        var options = new ConversionOptions { Seek = TimeSpan.FromSeconds(seeker) };
                        var outputFile = new MediaFile { Filename = string.Format("{0}\\Frame-{1}.jpeg", OutputPath, i) };
                        engine.GetThumbnail(Mp4Media, outputFile, options);

                        ExtractionProgress.Invoke(new Action(delegate 
                        {
                            ExtractionProgress.Value++;
                            ProgressLabel.Text = "Frames Done : " + i.ToString() + "/" + ExtractionProgress.Maximum.ToString();
                            PercentLabel.Text = ((i * 100) / ExtractionProgress.Maximum).ToString() + "%";
                        }));

                        if (CancelSignal) break;
                    }
                }
            });
        }

        private void ModeSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (((ComboBox)sender).SelectedIndex)
            {
                case 0:
                    Period = 1D / Mp4Media.Metadata.VideoData.Fps;
                    ExtractionProgress.Maximum = (int)TotalFrames;
                    ExpectedFramesLabel.Text = "Expected Frames : " + ExtractionProgress.Maximum.ToString();
                    break;

                case 1:
                    Period = 1;
                    ExtractionProgress.Maximum = (int)Mp4Media.Metadata.Duration.TotalSeconds;
                    ExpectedFramesLabel.Text = "Expected Frames : " + ((int)Mp4Media.Metadata.Duration.TotalSeconds).ToString();
                    break;
            }
        }
    }
}
