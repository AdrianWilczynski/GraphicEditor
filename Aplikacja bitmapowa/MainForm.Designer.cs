namespace BitmapEditor
{
    partial class MainForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel = new System.Windows.Forms.Panel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.histogramButton = new System.Windows.Forms.Button();
            this.binarizationLabel = new System.Windows.Forms.Label();
            this.binarizationTrackBar = new System.Windows.Forms.TrackBar();
            this.edgeDetectionButton = new System.Windows.Forms.Button();
            this.shaprenButton = new System.Windows.Forms.Button();
            this.blurButton = new System.Windows.Forms.Button();
            this.invertButton = new System.Windows.Forms.Button();
            this.contrastLabel = new System.Windows.Forms.Label();
            this.contrastTrackBar = new System.Windows.Forms.TrackBar();
            this.saveButton = new System.Windows.Forms.Button();
            this.valueLabel = new System.Windows.Forms.Label();
            this.saturationLabel = new System.Windows.Forms.Label();
            this.hueLabel = new System.Windows.Forms.Label();
            this.valueTrackBar = new System.Windows.Forms.TrackBar();
            this.saturationTrackBar = new System.Windows.Forms.TrackBar();
            this.hueTrackBar = new System.Windows.Forms.TrackBar();
            this.openFileButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.hueTimer = new System.Windows.Forms.Timer(this.components);
            this.saturationTimer = new System.Windows.Forms.Timer(this.components);
            this.valueTimer = new System.Windows.Forms.Timer(this.components);
            this.contrastTimer = new System.Windows.Forms.Timer(this.components);
            this.binarizationTimer = new System.Windows.Forms.Timer(this.components);
            this.undoButton = new System.Windows.Forms.Button();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.binarizationTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contrastTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saturationTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hueTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.AutoScroll = true;
            this.panel.Controls.Add(this.pictureBox);
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(784, 443);
            this.panel.TabIndex = 0;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(3, 3);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(601, 260);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.undoButton);
            this.groupBox.Controls.Add(this.histogramButton);
            this.groupBox.Controls.Add(this.binarizationLabel);
            this.groupBox.Controls.Add(this.binarizationTrackBar);
            this.groupBox.Controls.Add(this.edgeDetectionButton);
            this.groupBox.Controls.Add(this.shaprenButton);
            this.groupBox.Controls.Add(this.blurButton);
            this.groupBox.Controls.Add(this.invertButton);
            this.groupBox.Controls.Add(this.contrastLabel);
            this.groupBox.Controls.Add(this.contrastTrackBar);
            this.groupBox.Controls.Add(this.saveButton);
            this.groupBox.Controls.Add(this.valueLabel);
            this.groupBox.Controls.Add(this.saturationLabel);
            this.groupBox.Controls.Add(this.hueLabel);
            this.groupBox.Controls.Add(this.valueTrackBar);
            this.groupBox.Controls.Add(this.saturationTrackBar);
            this.groupBox.Controls.Add(this.hueTrackBar);
            this.groupBox.Controls.Add(this.openFileButton);
            this.groupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox.Location = new System.Drawing.Point(0, 449);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(784, 112);
            this.groupBox.TabIndex = 1;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Narzędzia";
            // 
            // histogramButton
            // 
            this.histogramButton.Enabled = false;
            this.histogramButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.histogramButton.Location = new System.Drawing.Point(127, 48);
            this.histogramButton.Name = "histogramButton";
            this.histogramButton.Size = new System.Drawing.Size(95, 23);
            this.histogramButton.TabIndex = 16;
            this.histogramButton.Text = "Histogram";
            this.histogramButton.UseVisualStyleBackColor = true;
            this.histogramButton.Click += new System.EventHandler(this.histogramButton_Click);
            // 
            // binarizationLabel
            // 
            this.binarizationLabel.AutoSize = true;
            this.binarizationLabel.Location = new System.Drawing.Point(690, 48);
            this.binarizationLabel.Name = "binarizationLabel";
            this.binarizationLabel.Size = new System.Drawing.Size(61, 13);
            this.binarizationLabel.TabIndex = 15;
            this.binarizationLabel.Text = "Binaryzacja";
            // 
            // binarizationTrackBar
            // 
            this.binarizationTrackBar.Enabled = false;
            this.binarizationTrackBar.Location = new System.Drawing.Point(668, 16);
            this.binarizationTrackBar.Maximum = 255;
            this.binarizationTrackBar.Name = "binarizationTrackBar";
            this.binarizationTrackBar.Size = new System.Drawing.Size(104, 45);
            this.binarizationTrackBar.TabIndex = 14;
            this.binarizationTrackBar.TickFrequency = 26;
            this.binarizationTrackBar.Scroll += new System.EventHandler(this.binarizationTrackBar_Scroll);
            // 
            // edgeDetectionButton
            // 
            this.edgeDetectionButton.Enabled = false;
            this.edgeDetectionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.edgeDetectionButton.Location = new System.Drawing.Point(631, 69);
            this.edgeDetectionButton.Name = "edgeDetectionButton";
            this.edgeDetectionButton.Size = new System.Drawing.Size(120, 31);
            this.edgeDetectionButton.TabIndex = 13;
            this.edgeDetectionButton.Text = "Wykrywanie krawędzi";
            this.edgeDetectionButton.UseVisualStyleBackColor = true;
            this.edgeDetectionButton.Click += new System.EventHandler(this.edgeDetectionButton_Click);
            // 
            // shaprenButton
            // 
            this.shaprenButton.Enabled = false;
            this.shaprenButton.Location = new System.Drawing.Point(505, 69);
            this.shaprenButton.Name = "shaprenButton";
            this.shaprenButton.Size = new System.Drawing.Size(120, 31);
            this.shaprenButton.TabIndex = 12;
            this.shaprenButton.Text = "Wyostrzenie";
            this.shaprenButton.UseVisualStyleBackColor = true;
            this.shaprenButton.Click += new System.EventHandler(this.shaprenButton_Click);
            // 
            // blurButton
            // 
            this.blurButton.Enabled = false;
            this.blurButton.Location = new System.Drawing.Point(379, 69);
            this.blurButton.Name = "blurButton";
            this.blurButton.Size = new System.Drawing.Size(120, 30);
            this.blurButton.TabIndex = 11;
            this.blurButton.Text = "Rozmycie";
            this.blurButton.UseVisualStyleBackColor = true;
            this.blurButton.Click += new System.EventHandler(this.blurButton_Click);
            // 
            // invertButton
            // 
            this.invertButton.Enabled = false;
            this.invertButton.Location = new System.Drawing.Point(253, 69);
            this.invertButton.Name = "invertButton";
            this.invertButton.Size = new System.Drawing.Size(120, 30);
            this.invertButton.TabIndex = 10;
            this.invertButton.Text = "Inwersja";
            this.invertButton.UseVisualStyleBackColor = true;
            this.invertButton.Click += new System.EventHandler(this.invertButton_Click);
            // 
            // contrastLabel
            // 
            this.contrastLabel.AutoSize = true;
            this.contrastLabel.Location = new System.Drawing.Point(588, 48);
            this.contrastLabel.Name = "contrastLabel";
            this.contrastLabel.Size = new System.Drawing.Size(46, 13);
            this.contrastLabel.TabIndex = 9;
            this.contrastLabel.Text = "Kontrast";
            // 
            // contrastTrackBar
            // 
            this.contrastTrackBar.Enabled = false;
            this.contrastTrackBar.Location = new System.Drawing.Point(558, 16);
            this.contrastTrackBar.Maximum = 100;
            this.contrastTrackBar.Minimum = -100;
            this.contrastTrackBar.Name = "contrastTrackBar";
            this.contrastTrackBar.Size = new System.Drawing.Size(104, 45);
            this.contrastTrackBar.TabIndex = 8;
            this.contrastTrackBar.TickFrequency = 20;
            this.contrastTrackBar.Scroll += new System.EventHandler(this.contrastTrackBar_Scroll);
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.saveButton.Enabled = false;
            this.saveButton.Location = new System.Drawing.Point(127, 21);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(95, 24);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Zapisz";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // valueLabel
            // 
            this.valueLabel.AutoSize = true;
            this.valueLabel.Location = new System.Drawing.Point(483, 48);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(46, 13);
            this.valueLabel.TabIndex = 6;
            this.valueLabel.Text = "Jasność";
            // 
            // saturationLabel
            // 
            this.saturationLabel.AutoSize = true;
            this.saturationLabel.Location = new System.Drawing.Point(366, 48);
            this.saturationLabel.Name = "saturationLabel";
            this.saturationLabel.Size = new System.Drawing.Size(57, 13);
            this.saturationLabel.TabIndex = 5;
            this.saturationLabel.Text = "Nasycenie";
            // 
            // hueLabel
            // 
            this.hueLabel.AutoSize = true;
            this.hueLabel.Location = new System.Drawing.Point(259, 48);
            this.hueLabel.Name = "hueLabel";
            this.hueLabel.Size = new System.Drawing.Size(41, 13);
            this.hueLabel.TabIndex = 0;
            this.hueLabel.Text = "Odcień";
            // 
            // valueTrackBar
            // 
            this.valueTrackBar.Enabled = false;
            this.valueTrackBar.Location = new System.Drawing.Point(448, 16);
            this.valueTrackBar.Maximum = 255;
            this.valueTrackBar.Minimum = -255;
            this.valueTrackBar.Name = "valueTrackBar";
            this.valueTrackBar.Size = new System.Drawing.Size(104, 45);
            this.valueTrackBar.TabIndex = 4;
            this.valueTrackBar.TickFrequency = 50;
            this.valueTrackBar.Scroll += new System.EventHandler(this.valueTrackBar_Scroll);
            // 
            // saturationTrackBar
            // 
            this.saturationTrackBar.Enabled = false;
            this.saturationTrackBar.Location = new System.Drawing.Point(338, 16);
            this.saturationTrackBar.Maximum = 100;
            this.saturationTrackBar.Minimum = -100;
            this.saturationTrackBar.Name = "saturationTrackBar";
            this.saturationTrackBar.Size = new System.Drawing.Size(104, 45);
            this.saturationTrackBar.TabIndex = 3;
            this.saturationTrackBar.TickFrequency = 20;
            this.saturationTrackBar.Scroll += new System.EventHandler(this.saturationTrackBar_Scroll);
            // 
            // hueTrackBar
            // 
            this.hueTrackBar.Enabled = false;
            this.hueTrackBar.Location = new System.Drawing.Point(228, 16);
            this.hueTrackBar.Maximum = 180;
            this.hueTrackBar.Minimum = -180;
            this.hueTrackBar.Name = "hueTrackBar";
            this.hueTrackBar.Size = new System.Drawing.Size(104, 45);
            this.hueTrackBar.TabIndex = 2;
            this.hueTrackBar.TickFrequency = 36;
            this.hueTrackBar.Scroll += new System.EventHandler(this.hueTrackBar_Scroll);
            // 
            // openFileButton
            // 
            this.openFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.openFileButton.Location = new System.Drawing.Point(12, 21);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(109, 79);
            this.openFileButton.TabIndex = 1;
            this.openFileButton.Text = "Otwórz";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "JPEG File|*.jpg|GIF File|*.gif|PNG File|*.png|BMP File|*.bmp";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "JPEG File|*.jpg|GIF File|*.gif|PNG File|*.png|BMP File|*.bmp";
            // 
            // hueTimer
            // 
            this.hueTimer.Interval = 500;
            this.hueTimer.Tick += new System.EventHandler(this.hueTimer_Tick);
            // 
            // saturationTimer
            // 
            this.saturationTimer.Interval = 500;
            this.saturationTimer.Tick += new System.EventHandler(this.saturationTimer_Tick);
            // 
            // valueTimer
            // 
            this.valueTimer.Interval = 500;
            this.valueTimer.Tick += new System.EventHandler(this.valueTimer_Tick);
            // 
            // contrastTimer
            // 
            this.contrastTimer.Interval = 500;
            this.contrastTimer.Tick += new System.EventHandler(this.contrastTimer_Tick);
            // 
            // binarizationTimer
            // 
            this.binarizationTimer.Interval = 500;
            this.binarizationTimer.Tick += new System.EventHandler(this.binarizationTimer_Tick);
            // 
            // undoButton
            // 
            this.undoButton.Enabled = false;
            this.undoButton.Location = new System.Drawing.Point(127, 76);
            this.undoButton.Name = "undoButton";
            this.undoButton.Size = new System.Drawing.Size(95, 23);
            this.undoButton.TabIndex = 17;
            this.undoButton.Text = "Cofnij";
            this.undoButton.UseVisualStyleBackColor = true;
            this.undoButton.Click += new System.EventHandler(this.undoButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.panel);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.Text = "Aplikacja bitmapowa";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.binarizationTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contrastTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saturationTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hueTrackBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.TrackBar hueTrackBar;
        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.Label hueLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Timer hueTimer;
        private System.Windows.Forms.TrackBar saturationTrackBar;
        private System.Windows.Forms.Timer saturationTimer;
        private System.Windows.Forms.TrackBar valueTrackBar;
        private System.Windows.Forms.Timer valueTimer;
        private System.Windows.Forms.Label saturationLabel;
        private System.Windows.Forms.Label valueLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label contrastLabel;
        private System.Windows.Forms.TrackBar contrastTrackBar;
        private System.Windows.Forms.Timer contrastTimer;
        private System.Windows.Forms.Button invertButton;
        private System.Windows.Forms.Button blurButton;
        private System.Windows.Forms.Button shaprenButton;
        private System.Windows.Forms.Button edgeDetectionButton;
        private System.Windows.Forms.Label binarizationLabel;
        private System.Windows.Forms.TrackBar binarizationTrackBar;
        private System.Windows.Forms.Timer binarizationTimer;
        private System.Windows.Forms.Button histogramButton;
        private System.Windows.Forms.Button undoButton;
    }
}

