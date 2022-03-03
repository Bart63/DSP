using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;

namespace DSP
{
    public partial class Card : Form
    {
        public Card(int n)
        {
            InitializeComponent();

            this.Text = "Karta " + n; 
        }

        public string GetName()
        {
            return this.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SeriesCollection collection = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Test",
                    Values = new ChartValues<double> {4, 7.58, 4, 69.4},
                    PointForeground = null,
                    PointGeometry = null,
                    LineSmoothness = 1,
                    PointGeometrySize = 5
                }
            };

            chart1Real.Series = collection;
        }

        
    }
}
