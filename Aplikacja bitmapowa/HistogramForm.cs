using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitmapEditor
{
    public partial class Histogram : Form
    {
        public Histogram(int[] vLevels)
        {
            InitializeComponent();

            histogramChart.Series[0].Points.DataBindY(vLevels);
        }
    }
}
