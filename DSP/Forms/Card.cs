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

        public QuantizedSignal quantizedSignal;

        public ReconstructedSignal reconstructedSignal;

        private Action<Card> removeCardCallback;

        SeriesCollection collection = null;

        public Card(int n, Action<Card> removeCardCallback)
        {
            InitializeComponent();

            this.Text = "Karta " + n;

            this.removeCardCallback = removeCardCallback;

            DisableTextBoxes();
        }

        public Card(Signal basicSignal, ReconstructedSignal reconstructedSignal)
        {
            this.signal = basicSignal;
            this.reconstructedSignal = reconstructedSignal;

            InitializeComponent();

            DisableTextBoxes();
        }
        public Card(QuantizedSignal quantizedSignal, ReconstructedSignal reconstructedSignal)
        {
            InitializeComponent();

            this.quantizedSignal = quantizedSignal;
            this.reconstructedSignal = reconstructedSignal;

            if (reconstructedSignal.isContinuous)
            {
                collection = new SeriesCollection
                {
                    new StepLineSeries
                    {
                        Values = new ChartValues<ObservablePoint>(quantizedSignal.GetRealPointsToChart()),
                        StrokeThickness = 1,
                        PointGeometry = null
                    },
                    new LineSeries
                    {
                        Values = new ChartValues<ObservablePoint>(reconstructedSignal.GetRealPointsToChart()),
                        PointForeground = null,
                        PointGeometry = null,
                        LineSmoothness = 0.7,
                        Fill = System.Windows.Media.Brushes.Transparent
                    },
                    
                };
            }
            else
            {
                collection = new SeriesCollection
                {
                    new LineSeries
                    {
                        Values = new ChartValues<ObservablePoint>(reconstructedSignal.reconstructedSignalPointsReal),

                        PointGeometrySize = 8,
                        Fill = System.Windows.Media.Brushes.Transparent,
                        StrokeThickness = 0,

                    }
                };
            }

            DisableTextBoxes();

            ShowCharts(ref chart1Real, ref chart2Real, collection, reconstructedSignal);
        }


        public Card(int n, Action<Card> removeCardCallback, Signal signal)
        {
            InitializeComponent();

            this.signal = signal;

            this.Text = "Karta " + n;

            this.removeCardCallback = removeCardCallback;

            
            if (signal.isContinuous)
            {
                collection = new SeriesCollection
                {
                    new LineSeries
                    {
                        Values = new ChartValues<ObservablePoint>(signal.GetRealPointsToChart()),
                        PointForeground = null,
                        PointGeometry = null,
                        LineSmoothness = 1,
                        Fill = System.Windows.Media.Brushes.Transparent
                    }
                };
            }
            else
            {
                collection = new SeriesCollection
                {
                    new LineSeries
                    {
                        Values = new ChartValues<ObservablePoint>(signal.PointsReal),

                        PointGeometrySize = 8,
                        Fill = System.Windows.Media.Brushes.Transparent,
                        StrokeThickness = 0,

                    }
                };
            }

            ShowCharts(ref chart1Real, ref chart2Real, collection, signal);

            DisableTextBoxes();
        }

        private void DisableTextBoxes()
        {
            var list = tableLayoutPanel1.Controls.OfType<MaskedTextBox>().ToList();

            list.AddRange(tableLayoutPanel2.Controls.OfType<MaskedTextBox>().ToList());

            foreach (var e in list)
            {
                e.Enabled = false;
            }
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
            

            switch (comboBoxSignalType.SelectedIndex)
            {
                case 0:

                    signal = new NoiseSignal(float.Parse(maskedTextBoxAmplitude.Text),
                        float.Parse(maskedTextBoxStartTime.Text),
                        float.Parse(maskedTextBoxDuration.Text),
                        int.Parse(maskedTextBoxFrequency.Text));

                    collection = new SeriesCollection
                    {
                        new LineSeries
                        {
                            Values = new ChartValues<ObservablePoint>(signal.GetRealPointsToChart()),
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
                        int.Parse(maskedTextBoxFrequency.Text));

                    collection = new SeriesCollection
                    {
                        new LineSeries
                        {
                            Values = new ChartValues<ObservablePoint>(signal.GetRealPointsToChart()),
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
                        int.Parse(maskedTextBoxFrequency.Text));

                    collection = new SeriesCollection
                    {
                        new LineSeries
                        {
                            Title = "Sin(t) * A",
                            Values = new ChartValues<ObservablePoint>(signal.GetRealPointsToChart()),
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
                        int.Parse(maskedTextBoxFrequency.Text));

                    collection = new SeriesCollection
                    {
                        new LineSeries
                        {
                            Values = new ChartValues<ObservablePoint>(signal.GetRealPointsToChart()),
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
                        int.Parse(maskedTextBoxFrequency.Text));

                    collection = new SeriesCollection
                    {
                        new LineSeries
                        {
                            Values = new ChartValues<ObservablePoint>(signal.GetRealPointsToChart()),
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
                        int.Parse(maskedTextBoxFrequency.Text),
                        float.Parse(maskedTextBoxFilling.Text));

                    collection = new SeriesCollection
                    {
                        new LineSeries
                        {
                            Values = new ChartValues<ObservablePoint>(signal.GetRealPointsToChart()),
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
                        int.Parse(maskedTextBoxFrequency.Text),
                        float.Parse(maskedTextBoxFilling.Text));

                    collection = new SeriesCollection
                    {
                        new LineSeries
                        {
                            Values = new ChartValues<ObservablePoint>(signal.GetRealPointsToChart()),
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
                        int.Parse(maskedTextBoxFrequency.Text),
                        float.Parse(maskedTextBoxFilling.Text));

                    collection = new SeriesCollection
                    {
                        new LineSeries
                        {
                            Values = new ChartValues<ObservablePoint>(signal.GetRealPointsToChart()),
                            PointForeground = null,
                            PointGeometry = null,
                            LineSmoothness = 0,
                            Fill = System.Windows.Media.Brushes.Transparent
                        }
                    };


                    break;

                case 8:

                    signal = new UnitJumpSignal(float.Parse(maskedTextBoxAmplitude.Text),
                        float.Parse(maskedTextBoxStartTime.Text),
                        float.Parse(maskedTextBoxDuration.Text),
                        int.Parse(maskedTextBoxFrequency.Text),
                        float.Parse(maskedTextBoxJumpTime.Text));

                    collection = new SeriesCollection
                    {
                        new LineSeries
                        {
                            Values = new ChartValues<ObservablePoint>(signal.GetRealPointsToChart()),
                            PointForeground = null,
                            PointGeometry = null,
                            LineSmoothness = 0,
                            Fill = System.Windows.Media.Brushes.Transparent
                        }
                    };


                    break;

                case 9:

                    signal = new UnitImpulseSignal(float.Parse(maskedTextBoxAmplitude.Text),
                        int.Parse(maskedTextBoxFirstSampleNumber.Text),
                        int.Parse(maskedTextBoxNuberOfSamples.Text),
                        int.Parse(maskedTextBoxFrequency.Text), 
                        int.Parse(maskedTextBoxSampleNumber.Text));

                    collection = new SeriesCollection
                    {
                        new LineSeries
                        {
                            Values = new ChartValues<ObservablePoint>(signal.GetRealPointsToChart()),
                            
                            PointGeometrySize = 8,
                            Fill = System.Windows.Media.Brushes.Transparent,
                            StrokeThickness = 0,
                            
                        }
                    };


                    break;


                case 10:

                    signal = new ImpulseNoiseSignal(float.Parse(maskedTextBoxAmplitude.Text),
                        float.Parse(maskedTextBoxStartTime.Text),
                        float.Parse(maskedTextBoxDuration.Text),
                        int.Parse(maskedTextBoxFrequency.Text),
                        float.Parse(maskedTextBoxProbability.Text));

                    collection = new SeriesCollection
                    {
                        new LineSeries
                        {
                            Values = new ChartValues<ObservablePoint>(signal.GetRealPointsToChart()),

                            PointGeometrySize = 8,
                            Fill = System.Windows.Media.Brushes.Transparent,
                            StrokeThickness = 0,

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

            TextBoxAverageSignal.Text = signal.AverageSignalValue.ToString();
            TextBoxAverageAbsSignal.Text = signal.AverageSignalAbsValue.ToString();
            TextBoxAveragePower.Text = signal.AverageSignalPower.ToString();
            TextBoxVariance.Text = signal.Variance.ToString();
            TextBoxEffectiveValue.Text = signal.EffectiveValue.ToString();

            maskedTextBoxAmplitude.Text = signal.A.ToString();
            maskedTextBoxDuration.Text = signal.d.ToString();
            maskedTextBoxFrequency.Text = signal.f.ToString();
            maskedTextBoxPeriod.Text = signal.T.ToString();
            maskedTextBoxStartTime.Text = signal.t1.ToString();

            int numberOfSections = 5;
            if (comboBoxNumberOfSections.SelectedItem != null)
            {
                numberOfSections = int.Parse(comboBoxNumberOfSections.SelectedItem.ToString());
            }


            var histogram = Histogram.CreateHistogram((signal.isContinuous) ? signal.GetRealPointsWithTime
                (signal.t1, signal.endTime) : signal.PointsReal, numberOfSections);

            SeriesCollection histogramCollectionReal = new SeriesCollection
                {
                    new ColumnSeries
                    {
                        Values = new ChartValues<int>(histogram.data)
                    }
                };

            
            if (histogramChart.AxisX.Count() > 0)
                histogramChart.AxisX.RemoveAt(0);

            histogramChart.AxisX.Add(new Axis
            {
                Labels = histogram.labels,
                Foreground = System.Windows.Media.Brushes.Black,
                Separator = new Separator { Step = 1 },
            });

            if (histogramChart.AxisY.Count() > 0)
                histogramChart.AxisY.RemoveAt(0);

            histogramChart.AxisY.Add(new Axis
            {
                MinValue = 0,
                Foreground = System.Windows.Media.Brushes.Black,
            });

            histogramChart.Series = histogramCollectionReal;

        }

        private void Card_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (removeCardCallback != null)
                removeCardCallback(this);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (signal != null)
                FileManager.Save(signal);
        }

        private void comboBoxSignalType_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisableTextBoxes();

            maskedTextBoxFrequency.Enabled = true;

            switch (comboBoxSignalType.SelectedIndex)
            {
                case 0:

                    maskedTextBoxAmplitude.Enabled =
                        maskedTextBoxStartTime.Enabled = maskedTextBoxDuration.Enabled = true;

                    break;

                case 1:

                    maskedTextBoxAmplitude.Enabled =
                        maskedTextBoxStartTime.Enabled = maskedTextBoxDuration.Enabled = true;

                    break;

                case 2:

                    maskedTextBoxAmplitude.Enabled =
                        maskedTextBoxStartTime.Enabled = maskedTextBoxDuration.Enabled = 
                        maskedTextBoxPeriod.Enabled = true;

                    break;

                case 3:

                    maskedTextBoxAmplitude.Enabled =
                        maskedTextBoxStartTime.Enabled = maskedTextBoxDuration.Enabled =
                        maskedTextBoxPeriod.Enabled = true;

                    break;

                case 4:

                    maskedTextBoxAmplitude.Enabled =
                        maskedTextBoxStartTime.Enabled = maskedTextBoxDuration.Enabled =
                        maskedTextBoxPeriod.Enabled = true;

                    break;

                case 5:

                    maskedTextBoxAmplitude.Enabled =
                        maskedTextBoxStartTime.Enabled = maskedTextBoxDuration.Enabled =
                        maskedTextBoxPeriod.Enabled = maskedTextBoxFilling.Enabled = true;

                    break;

                case 6:

                    maskedTextBoxAmplitude.Enabled =
                        maskedTextBoxStartTime.Enabled = maskedTextBoxDuration.Enabled =
                        maskedTextBoxPeriod.Enabled = maskedTextBoxFilling.Enabled = true;

                    break;

                case 7:

                    maskedTextBoxAmplitude.Enabled =
                        maskedTextBoxStartTime.Enabled = maskedTextBoxDuration.Enabled =
                        maskedTextBoxPeriod.Enabled = maskedTextBoxFilling.Enabled = true;

                    break;

                case 8:

                    maskedTextBoxAmplitude.Enabled =
                        maskedTextBoxStartTime.Enabled = maskedTextBoxDuration.Enabled =
                        maskedTextBoxJumpTime.Enabled = true;

                    break;

                case 9:

                    maskedTextBoxAmplitude.Enabled =
                        maskedTextBoxFirstSampleNumber.Enabled = maskedTextBoxSampleNumber.Enabled = 
                        maskedTextBoxNuberOfSamples.Enabled = true;

                    break;

                case 10:

                    maskedTextBoxAmplitude.Enabled =
                        maskedTextBoxStartTime.Enabled = maskedTextBoxDuration.Enabled =
                        maskedTextBoxProbability.Enabled = true;

                    break;
            }
        }

        private void buttonQuantization_Click(object sender, EventArgs e)
        {
            if (signal == null || maskedTextBoxQuantizationFrequency.Text == "")
                return;

            quantizedSignal = new QuantizedSignal(signal.A, signal.t1, signal.d, signal.T, signal.f, signal.isContinuous,
                signal.PointsReal, int.Parse(maskedTextBoxQuantizationFrequency.Text));

            if (collection.Count > 1)
                collection.RemoveAt(1);

            collection.Add(new StepLineSeries
            {
                Values = new ChartValues<ObservablePoint>(quantizedSignal.GetRealPointsToChart()),
                PointGeometry = null
            });
        }

        private void buttonRecontruction_Click(object sender, EventArgs e)
        {
            ReconstructedSignal reconstructedSignal = new ReconstructedSignal(quantizedSignal.A, quantizedSignal.t1, quantizedSignal.d,
                quantizedSignal.T, quantizedSignal.f, quantizedSignal.isContinuous, comboBoxReconstructionType.SelectedIndex,
                quantizedSignal.k, quantizedSignal.quantizedSignalPoints);

            Card card = new Card(quantizedSignal, reconstructedSignal);

            card.Show();
        }
    }
}
