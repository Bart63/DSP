using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DSP.Helpers;
using DSP.Signals;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;

namespace DSP
{
    public partial class Card : Form
    {
        public Signal signal;

        private Action<Card> removeCardCallback;

        public Card(int n, Action<Card> removeCardCallback)
        {
            InitializeComponent();

            this.Text = "Karta " + n;

            this.removeCardCallback = removeCardCallback;

        }

        public Card(int n, Action<Card> removeCardCallback, Signal signal)
        {
            InitializeComponent();

            this.Text = "Karta " + n;

            this.removeCardCallback = removeCardCallback;

            SeriesCollection collection = new SeriesCollection
            {
                new LineSeries
                {
                    Values = new ChartValues<ObservablePoint>(signal.PointsReal),
                    PointForeground = null,
                    PointGeometry = null,
                    LineSmoothness = 1,
                    Fill = System.Windows.Media.Brushes.Transparent
                }
            };

            ShowCharts(ref chart1Real, ref chart2Real, collection, signal);
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
                Foreground = System.Windows.Media.Brushes.Black,
                
            }); 

            chart1Real.AxisY.Add(new Axis
            {
                Title = "A",
                Foreground = System.Windows.Media.Brushes.Black
            });
            chart2Real.AxisY.Add(new Axis
            {
                Foreground = System.Windows.Media.Brushes.Black
            });

        }

        private void buttonGenerateSignal_Click(object sender, EventArgs e)
        {
            SeriesCollection collection = null;

            switch (comboBoxSignalType.SelectedIndex)
            {
                case 0:

                    signal = new NoiseSignal(float.Parse(maskedTextBoxAmplitude.Text),
                        float.Parse(maskedTextBoxStartTime.Text),
                        float.Parse(maskedTextBoxDuration.Text),
                        int.Parse(maskedTextBoxFrequency.Text), true);

                    collection = new SeriesCollection
                    {
                        new LineSeries
                        {
                            Values = new ChartValues<ObservablePoint>(signal.PointsReal),
                            PointForeground = null,
                            PointGeometry = null,
                            LineSmoothness = 0,
                            Fill = System.Windows.Media.Brushes.Transparent
                        }
                    };


                    break;

                case 1:

                    signal = new GaussianNoiseSignal(float.Parse(maskedTextBoxAmplitude.Text),
                        float.Parse(maskedTextBoxStartTime.Text),
                        float.Parse(maskedTextBoxDuration.Text),
                        int.Parse(maskedTextBoxFrequency.Text), true);

                    collection = new SeriesCollection
                    {
                        new LineSeries
                        {
                            Values = new ChartValues<ObservablePoint>(signal.PointsReal),
                            PointForeground = null,
                            PointGeometry = null,
                            LineSmoothness = 0,
                            Fill = System.Windows.Media.Brushes.Transparent
                        }
                    };


                    break;


                case 2:

                    signal = new SinSignal(float.Parse(maskedTextBoxAmplitude.Text),
                        float.Parse(maskedTextBoxStartTime.Text),
                        float.Parse(maskedTextBoxDuration.Text),
                        float.Parse(maskedTextBoxPeriod.Text),
                        int.Parse(maskedTextBoxFrequency.Text), true);

                    collection = new SeriesCollection
                    {
                        new LineSeries
                        {
                            Title = "Sin(t) * A",
                            Values = new ChartValues<ObservablePoint>(signal.PointsReal),
                            PointForeground = null,
                            PointGeometry = null,
                            LineSmoothness = 1,
                            Fill = System.Windows.Media.Brushes.Transparent
                        }
                    };


                    break;

                case 3:

                    signal = new SinSignal2(float.Parse(maskedTextBoxAmplitude.Text),
                        float.Parse(maskedTextBoxStartTime.Text),
                        float.Parse(maskedTextBoxDuration.Text),
                        float.Parse(maskedTextBoxPeriod.Text),
                        int.Parse(maskedTextBoxFrequency.Text), true);

                    collection = new SeriesCollection
                    {
                        new LineSeries
                        {
                            Values = new ChartValues<ObservablePoint>(signal.PointsReal),
                            PointForeground = null,
                            PointGeometry = null,
                            LineSmoothness = 1,
                            Fill = System.Windows.Media.Brushes.Transparent
                        }
                    };


                    break;

                case 4:

                    signal = new SinSignal3(float.Parse(maskedTextBoxAmplitude.Text),
                        float.Parse(maskedTextBoxStartTime.Text),
                        float.Parse(maskedTextBoxDuration.Text),
                        float.Parse(maskedTextBoxPeriod.Text),
                        int.Parse(maskedTextBoxFrequency.Text), true);

                    collection = new SeriesCollection
                    {
                        new LineSeries
                        {
                            Values = new ChartValues<ObservablePoint>(signal.PointsReal),
                            PointForeground = null,
                            PointGeometry = null,
                            LineSmoothness = 0.5,
                            Fill = System.Windows.Media.Brushes.Transparent
                        }
                    };


                    break;

                case 5:

                    signal = new RectSignal(float.Parse(maskedTextBoxAmplitude.Text),
                        float.Parse(maskedTextBoxStartTime.Text),
                        float.Parse(maskedTextBoxDuration.Text),
                        float.Parse(maskedTextBoxPeriod.Text),
                        int.Parse(maskedTextBoxFrequency.Text), true,
                        float.Parse(maskedTextBoxFilling.Text));

                    collection = new SeriesCollection
                    {
                        new LineSeries
                        {
                            Values = new ChartValues<ObservablePoint>(signal.PointsReal),
                            PointForeground = null,
                            PointGeometry = null,
                            LineSmoothness = 0,
                            Fill = System.Windows.Media.Brushes.Transparent
                        }
                    };


                    break;

                case 6:

                    signal = new RectSimSignal(float.Parse(maskedTextBoxAmplitude.Text),
                        float.Parse(maskedTextBoxStartTime.Text),
                        float.Parse(maskedTextBoxDuration.Text),
                        float.Parse(maskedTextBoxPeriod.Text),
                        int.Parse(maskedTextBoxFrequency.Text), true,
                        float.Parse(maskedTextBoxFilling.Text));

                    collection = new SeriesCollection
                    {
                        new LineSeries
                        {
                            Values = new ChartValues<ObservablePoint>(signal.PointsReal),
                            PointForeground = null,
                            PointGeometry = null,
                            LineSmoothness = 0,
                            Fill = System.Windows.Media.Brushes.Transparent
                        }
                    };


                    break;

                case 7:

                    signal = new TrianSignal(float.Parse(maskedTextBoxAmplitude.Text),
                        float.Parse(maskedTextBoxStartTime.Text),
                        float.Parse(maskedTextBoxDuration.Text),
                        float.Parse(maskedTextBoxPeriod.Text),
                        int.Parse(maskedTextBoxFrequency.Text), true,
                        float.Parse(maskedTextBoxFilling.Text));

                    collection = new SeriesCollection
                    {
                        new LineSeries
                        {
                            Values = new ChartValues<ObservablePoint>(signal.PointsReal),
                            PointForeground = null,
                            PointGeometry = null,
                            LineSmoothness = 0,
                            Fill = System.Windows.Media.Brushes.Transparent
                        }
                    };


                    break;

                
            }

            if (collection != null && signal != null)
            {
                ShowCharts(ref chart1Real, ref chart2Real, collection, signal);
            }
        }

        private void ShowCharts (ref LiveCharts.WinForms.CartesianChart chart, 
            ref LiveCharts.WinForms.CartesianChart histogramChart, 
            SeriesCollection collection, Signal signal)
        {
            chart.Series = collection;

            maskedTextBoxAverageSignal.Text = signal.AverageSignalValue.ToString();
            maskedTextBoxAverageAbsSignal.Text = signal.AverageSignalAbsValue.ToString();
            maskedTextBoxAveragePower.Text = signal.AverageSignalPower.ToString();
            maskedTextBoxVariance.Text = signal.Variance.ToString();
            maskedTextBoxEffectiveValue.Text = signal.EffectiveValue.ToString();

            int numberOfSections = 5;
            if (comboBoxNumberOfSections.SelectedItem != null)
            {
                numberOfSections = int.Parse(comboBoxNumberOfSections.SelectedItem.ToString());
            }

            var histogram = Histogram.CreateHistogram(signal.PointsReal, numberOfSections);

            SeriesCollection histogramCollectionReal = new SeriesCollection
                {
                    new ColumnSeries
                    {
                        Values = new ChartValues<int>(histogram.data)
                    }
                };

            histogramChart.Series = histogramCollectionReal;

            if (histogramChart.AxisX.Count() > 0)
                histogramChart.AxisX.RemoveAt(0);

            histogramChart.AxisX.Add(new Axis
            {
                Labels = histogram.labels,
                Foreground = System.Windows.Media.Brushes.Black,
                Separator = new Separator { Step = 1 },
            });

        
    }

        private void Card_FormClosing(object sender, FormClosingEventArgs e)
        {
            removeCardCallback(this);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (signal != null)
                FileManager.Save(signal);
        }
    }
}
