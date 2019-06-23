using System;
using System.Drawing;
using System.Windows.Forms;

namespace BitmapEditor
{
    public partial class MainForm : Form
    {
        private BitmapEditor bitmapEditor;

        public MainForm()
        {
            InitializeComponent();
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap bitmap = Bitmap.FromFile(openFileDialog.FileName) as Bitmap;

                bitmapEditor = new BitmapEditor(bitmap);

                pictureBox.Image?.Dispose();
                pictureBox.Image = bitmapEditor.CurrentlyEditedBitmap;

                EnableControls();
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                bitmapEditor.CurrentlyEditedBitmap.Save(saveFileDialog.FileName);
            }
        }

        private void histogramButton_Click(object sender, EventArgs e)
        {
            new Histogram(bitmapEditor.GetVLelevs()).Show();
        }

        private void undoButton_Click(object sender, EventArgs e)
        {
            bitmapEditor.Undo();
            pictureBox.Image = bitmapEditor.CurrentlyEditedBitmap;
        }

        private void hueTrackBar_Scroll(object sender, EventArgs e)
        {
            hueTimer.Stop();
            hueTimer.Start();
        }

        private void hueTimer_Tick(object sender, EventArgs e)
        {
            hueTimer.Stop();
            bitmapEditor.TransformAllPixels(Transformations.TransformHue(hueTrackBar.Value));
            pictureBox.Image = bitmapEditor.CurrentlyEditedBitmap;
            hueTrackBar.Value = 0;
        }

        private void saturationTrackBar_Scroll(object sender, EventArgs e)
        {
            saturationTimer.Stop();
            saturationTimer.Start();
        }

        private void saturationTimer_Tick(object sender, EventArgs e)
        {
            saturationTimer.Stop();
            bitmapEditor.TransformAllPixels(Transformations.TransformSaturation(saturationTrackBar.Value));
            pictureBox.Image = bitmapEditor.CurrentlyEditedBitmap;
            saturationTrackBar.Value = 0;
        }

        private void valueTrackBar_Scroll(object sender, EventArgs e)
        {
            valueTimer.Stop();
            valueTimer.Start();
        }

        private void valueTimer_Tick(object sender, EventArgs e)
        {
            valueTimer.Stop();
            bitmapEditor.TransformAllPixels(Transformations.TransformValue(valueTrackBar.Value));
            pictureBox.Image = bitmapEditor.CurrentlyEditedBitmap;
            valueTrackBar.Value = 0;
        }

        private void contrastTrackBar_Scroll(object sender, EventArgs e)
        {
            contrastTimer.Stop();
            contrastTimer.Start();
        }

        private void contrastTimer_Tick(object sender, EventArgs e)
        {
            contrastTimer.Stop();
            bitmapEditor.TransformAllPixels(Transformations.TransformContrast(contrastTrackBar.Value));
            pictureBox.Image = bitmapEditor.CurrentlyEditedBitmap;
            contrastTrackBar.Value = 0;
        }

        private void binarizationTrackBar_Scroll(object sender, EventArgs e)
        {
            binarizationTimer.Stop();
            binarizationTimer.Start();
        }

        private void binarizationTimer_Tick(object sender, EventArgs e)
        {
            binarizationTimer.Stop();
            bitmapEditor.TransformAllPixels(Transformations.Binarize(binarizationTrackBar.Value));
            pictureBox.Image = bitmapEditor.CurrentlyEditedBitmap;
            binarizationTrackBar.Value = 0;
        }

        private void invertButton_Click(object sender, EventArgs e)
        {
            bitmapEditor.TransformAllPixels(Transformations.Invert);
            pictureBox.Image = bitmapEditor.CurrentlyEditedBitmap;
        }

        private void blurButton_Click(object sender, EventArgs e)
        {
            bitmapEditor.TransformAllPixelsWithNeighbors(Transformations.Blur);
            pictureBox.Image = bitmapEditor.CurrentlyEditedBitmap;
        }

        private void shaprenButton_Click(object sender, EventArgs e)
        {
            bitmapEditor.TransformAllPixelsWithNeighbors(Transformations.Sharpen);
            pictureBox.Image = bitmapEditor.CurrentlyEditedBitmap;
        }

        private void edgeDetectionButton_Click(object sender, EventArgs e)
        {
            bitmapEditor.TransformAllPixelsWithNeighbors(Transformations.DetectEdges);
            pictureBox.Image = bitmapEditor.CurrentlyEditedBitmap;
        }

        private void EnableControls()
        {
            hueTrackBar.Enabled = true;
            saturationTrackBar.Enabled = true;
            valueTrackBar.Enabled = true;
            contrastTrackBar.Enabled = true;
            binarizationTrackBar.Enabled = true;

            invertButton.Enabled = true;
            blurButton.Enabled = true;
            shaprenButton.Enabled = true;
            edgeDetectionButton.Enabled = true;

            histogramButton.Enabled = true;
            saveButton.Enabled = true;
            undoButton.Enabled = true;
        }
    }
}
