using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

using MediaToolkit;
using MediaToolkit.Model;
using MediaToolkit.Options;

namespace Motta_s_Frame_Extractor
{
    public partial class Form1 : Form
    {
        string OutputPath, InputPath;
        double TotalFrames, Period;

        MediaFile Mp4Media;

        public Form1()
        {
            InitializeComponent();
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
                OutputPath = Directory.GetParent(InputPath) + "\\Eggxtracted - " + Path.GetFileNameWithoutExtension(InputPath);
                VideoPathBox.Text = InputPath;
                OutputPathBox.Text = OutputPath;

                Mp4Media = new MediaFile { Filename = InputPath };

                using (var engine = new Engine())
                {
                    engine.GetMetadata(Mp4Media);
                }

                TotalFrames = Mp4Media.Metadata.Duration.TotalSeconds * Mp4Media.Metadata.VideoData.Fps;
                EggxtractionProgress.Maximum = (int)TotalFrames;
                EggxtractionProgress.Value = 0;

                TitleLabel.Text = "Title : " + Path.GetFileNameWithoutExtension(InputPath);
                FrameRateLabel.Text = "Frame Rate : " + Mp4Media.Metadata.VideoData.Fps.ToString() + " FPS";
                DurationLabel.Text = "Duration : " + Mp4Media.Metadata.Duration.ToString();
                ExpectedFramesLabel.Text = "Expected Frames : " + EggxtractionProgress.Maximum.ToString();

                ModeSelector.SelectedIndex = 0;
                EggBox.Enabled = true;
            }
        }

        private async void EggxtractButton_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory(OutputPath);

            EggBox.Enabled = false;
            VideoPathBox.Enabled = false;
            SelectVideoButton.Enabled = false;

            await StartEggxtraction();

            DialogResult r = MessageBox.Show(EggxtractionProgress.Maximum.ToString() + " Frames were eggxtracted. Open Output folder?", "Operation Completed Successfully", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(r == DialogResult.Yes)
                System.Diagnostics.Process.Start(OutputPath);

            ProgressLabel.Text = "";
            PercentLabel.Text = "";
            VideoPathBox.Enabled = true;
            SelectVideoButton.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async Task StartEggxtraction()
        {
            await Task.Run(delegate
            {
                using (var engine = new Engine())
                {
                    double seeker = 0;

                    for (int i = 0; i < EggxtractionProgress.Maximum; i++, seeker += Period)
                    {
                        var options = new ConversionOptions { Seek = TimeSpan.FromSeconds(seeker) };
                        var outputFile = new MediaFile { Filename = string.Format("{0}\\EggFrame-{1}.jpeg", OutputPath, i) };
                        engine.GetThumbnail(Mp4Media, outputFile, options);

                        EggxtractionProgress.Invoke(new Action(delegate 
                        {
                            EggxtractionProgress.Value++;
                            ProgressLabel.Text = "Frames Done : " + i.ToString() + "/" + EggxtractionProgress.Maximum.ToString();
                            PercentLabel.Text = ((i * 100) / EggxtractionProgress.Maximum).ToString() + "%";
                        }));
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
                    EggxtractionProgress.Maximum = (int)TotalFrames;
                    ExpectedFramesLabel.Text = "Expected Frames : " + EggxtractionProgress.Maximum.ToString();
                    break;

                case 1:
                    Period = 1;
                    EggxtractionProgress.Maximum = (int)Mp4Media.Metadata.Duration.TotalSeconds;
                    ExpectedFramesLabel.Text = "Expected Frames : " + ((int)Mp4Media.Metadata.Duration.TotalSeconds).ToString();
                    break;
            }
        }
    }
}
