using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DSP.Signals;
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
            Signal signal = new SinSignal(15, 2, 14, 2, 100);


            SeriesCollection collection = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Sin(t) * 4",
                    Values = new ChartValues<ObservablePoint>(signal.points),
                    PointForeground = null,
                    PointGeometry = null,
                    LineSmoothness = 1,
                    
                }
            };

            chart1Real.Series = collection;

            chart1Real.AxisX.Add(new Axis
            {
                Title = "t [s]",
                
            });

            chart1Real.AxisY.Add(new Axis
            {
                Title = "A",
                
            });

            
        }

        
    }
}
