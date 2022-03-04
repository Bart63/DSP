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
            

            chart1Real.AxisX.Add(new Axis
            {
                Title = "t [s]",
                
            });

            chart1Real.AxisY.Add(new Axis
            {
                Title = "A",
                
            });

            
        }

        private void buttonGenerateSignal_Click(object sender, EventArgs e)
        {
            switch (comboBoxSignalType.SelectedIndex)
            {
                case 2:

                    Signal signal = new SinSignal(float.Parse(maskedTextBoxAmplitude.Text),
                        float.Parse(maskedTextBoxStartTime.Text),
                        float.Parse(maskedTextBoxDuration.Text),
                        float.Parse(maskedTextBoxPeriod.Text),
                        int.Parse(maskedTextBoxFrequency.Text));

                    
                    SeriesCollection collection = new SeriesCollection
                    {
                        new LineSeries
                        {
                            Title = "Sin(t) * A",
                            Values = new ChartValues<ObservablePoint>(signal.points),
                            PointForeground = null,
                            PointGeometry = null,
                            LineSmoothness = 1,

                        }
                    };

                    chart1Real.Series = collection;

                    break;
            }
        }
    }
}
