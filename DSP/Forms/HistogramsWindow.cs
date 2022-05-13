using DSP.Helpers;
using DSP.Signals;
using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSP
{
    public partial class HistogramsWindow : Form
    {
        int numberOfSections;
        Signal[] signals;
        string[] names;
        Signal s;
        public HistogramsWindow(Signal[] signals, string[] names)
        {
            InitializeComponent();

            numberOfSections = 5;
            this.names = names;
            this.signals = signals;

            comboBoxNumberOfSections.SelectedIndex = 0;
            
            for (int i = 0; i < signals.Count(); i++)
            {
                if (signals[i] != null)
                    comboBoxSignalType.Items.Add(names[i]);
            }

            if (comboBoxSignalType.Items.Count != 0)
            {
                comboBoxSignalType.SelectedIndex = 0;

                comboBoxSignalType_SelectedIndexChanged(null, null);
            }


        }

        private void GenerateHistogram(ref LiveCharts.WinForms.CartesianChart histogramChart, Signal signal)
        {
            if (s == null)
                return;

            var histogram = Histogram.CreateHistogram((signal.isContinuous) ? signal.GetRealPointsWithTime
                (signal.t1, signal.endTime) : signal.PointsReal, numberOfSections);

            SeriesCollection histogramCollectionReal = new SeriesCollection
                {
                    new ColumnSeries
                    {
                        Values = new ChartValues<int>(histogram.data)
                    }
                };


            histogramChart.AxisX.Clear();
            histogramChart.AxisY.Clear();

            histogramChart.AxisX.Add(new Axis
            {
                Labels = histogram.labels,
                Foreground = System.Windows.Media.Brushes.Black,
                Separator = new Separator { Step = 1 },
            });
            histogramChart.AxisY.Add(new Axis
            {
                MinValue = 0,
                MaxValue = histogram.data.ToList().Max() + 1,
                Foreground = System.Windows.Media.Brushes.Black,
            });
            histogramChart.Series = histogramCollectionReal;
        }

        

        private void comboBoxSignalType_SelectedIndexChanged(object sender, EventArgs e)
        {

            for (int i = 0; i < names.Count(); i++)
            {
                if (names[i] == comboBoxSignalType.SelectedItem.ToString())
                {
                    s = signals[i];

                }
            }

            if (s != null)
                GenerateHistogram(ref chart1, s);
        }

        private void comboBoxNumberOfSections_SelectedIndexChanged(object sender, EventArgs e)
        {
            numberOfSections = int.Parse(comboBoxNumberOfSections.SelectedItem.ToString());

            GenerateHistogram(ref chart1, s);
        }
    }
}
