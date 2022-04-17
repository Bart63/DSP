﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
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

        public SampledSignal sampledSignal;

        private Action<Card> removeCardCallback;

        private bool[] ChartVisibility = new bool[4] { true, true, true, true };

        private bool[] ChartExistence = new bool[4] { false, false, false, false };

        private string[] ChartNames = new string[4] { "Sygnał oryginalny", "Sygnał spróbkowany",
        "Sygnał skwantowany", "Sygnał zrekonstruowany"};

        SeriesCollection collection = null;
        

        public Card(int n, Action<Card> removeCardCallback)
        {
            InitializeComponent();

            this.Text = "Karta " + n;

            this.removeCardCallback = removeCardCallback;

            maskedTextBoxFrequency.Text = "10000";

            DisableTextBoxes();
        }

        public Card(Signal basicSignal, SampledSignal sampledSignal, QuantizedSignal quantizedSignal, ReconstructedSignal reconstructedSignal)
        {
            signal = basicSignal;
            this.reconstructedSignal = reconstructedSignal;
            this.quantizedSignal = quantizedSignal;
            this.sampledSignal = sampledSignal;

            InitializeComponent();

            ChartExistence[0] = signal != null;
            ChartExistence[1] = sampledSignal != null;
            ChartExistence[2] = quantizedSignal != null;
            ChartExistence[3] = reconstructedSignal != null;

            
            DisableTextBoxes();

            UpdateChartCollection();

            ShowCharts(ref chart1Real, collection, reconstructedSignal);

            ShowStats();
        }
        
        private void ShowStats()
        {
            if (signal == null)
                return;

            maskedTextBoxAmplitude.Text = signal.A.ToString();
            maskedTextBoxDuration.Text = signal.d.ToString();
            maskedTextBoxFrequency.Text = signal.f.ToString();
            maskedTextBoxPeriod.Text = signal.T.ToString();
            maskedTextBoxStartTime.Text = signal.t1.ToString();
        }

        public Card(int n, Action<Card> removeCardCallback, Signal signal)
        {
            InitializeComponent();

            this.signal = signal;

            this.Text = "Karta " + n;

            this.removeCardCallback = removeCardCallback;

            ChartExistence[0] = signal != null;

            UpdateChartCollection();

            
            ShowCharts(ref chart1Real, collection, signal);

            ShowStats();

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


        

        private void buttonGenerateSignal_Click(object sender, EventArgs e)
        {
            

            switch (comboBoxSignalType.SelectedIndex)
            {
                case 0:

                    signal = new NoiseSignal(float.Parse(maskedTextBoxAmplitude.Text),
                        float.Parse(maskedTextBoxStartTime.Text),
                        float.Parse(maskedTextBoxDuration.Text),
                        int.Parse(maskedTextBoxFrequency.Text));

                    
                    break;

                case 1:

                    signal = new GaussianNoiseSignal(float.Parse(maskedTextBoxAmplitude.Text),
                        float.Parse(maskedTextBoxStartTime.Text),
                        float.Parse(maskedTextBoxDuration.Text),
                        int.Parse(maskedTextBoxFrequency.Text));

                    

                    break;


                case 2:

                    signal = new SinSignal(float.Parse(maskedTextBoxAmplitude.Text),
                        float.Parse(maskedTextBoxStartTime.Text),
                        float.Parse(maskedTextBoxDuration.Text),
                        float.Parse(maskedTextBoxPeriod.Text),
                        int.Parse(maskedTextBoxFrequency.Text));

                    
                    break;

                case 3:

                    signal = new SinSignal2(float.Parse(maskedTextBoxAmplitude.Text),
                        float.Parse(maskedTextBoxStartTime.Text),
                        float.Parse(maskedTextBoxDuration.Text),
                        float.Parse(maskedTextBoxPeriod.Text),
                        int.Parse(maskedTextBoxFrequency.Text));

                    break;

                case 4:

                    signal = new SinSignal3(float.Parse(maskedTextBoxAmplitude.Text),
                        float.Parse(maskedTextBoxStartTime.Text),
                        float.Parse(maskedTextBoxDuration.Text),
                        float.Parse(maskedTextBoxPeriod.Text),
                        int.Parse(maskedTextBoxFrequency.Text));


                    break;

                case 5:

                    signal = new RectSignal(float.Parse(maskedTextBoxAmplitude.Text),
                        float.Parse(maskedTextBoxStartTime.Text),
                        float.Parse(maskedTextBoxDuration.Text),
                        float.Parse(maskedTextBoxPeriod.Text),
                        int.Parse(maskedTextBoxFrequency.Text),
                        float.Parse(maskedTextBoxFilling.Text));

                    
                    break;

                case 6:

                    signal = new RectSimSignal(float.Parse(maskedTextBoxAmplitude.Text),
                        float.Parse(maskedTextBoxStartTime.Text),
                        float.Parse(maskedTextBoxDuration.Text),
                        float.Parse(maskedTextBoxPeriod.Text),
                        int.Parse(maskedTextBoxFrequency.Text),
                        float.Parse(maskedTextBoxFilling.Text));


                    break;

                case 7:

                    signal = new TrianSignal(float.Parse(maskedTextBoxAmplitude.Text),
                        float.Parse(maskedTextBoxStartTime.Text),
                        float.Parse(maskedTextBoxDuration.Text),
                        float.Parse(maskedTextBoxPeriod.Text),
                        int.Parse(maskedTextBoxFrequency.Text),
                        float.Parse(maskedTextBoxFilling.Text));

                    break;

                case 8:

                    signal = new UnitJumpSignal(float.Parse(maskedTextBoxAmplitude.Text),
                        float.Parse(maskedTextBoxStartTime.Text),
                        float.Parse(maskedTextBoxDuration.Text),
                        int.Parse(maskedTextBoxFrequency.Text),
                        float.Parse(maskedTextBoxJumpTime.Text));


                    break;

                case 9:

                    signal = new UnitImpulseSignal(float.Parse(maskedTextBoxAmplitude.Text),
                        int.Parse(maskedTextBoxFirstSampleNumber.Text),
                        int.Parse(maskedTextBoxNuberOfSamples.Text),
                        int.Parse(maskedTextBoxFrequency.Text), 
                        int.Parse(maskedTextBoxSampleNumber.Text));

                    
                    break;


                case 10:

                    signal = new ImpulseNoiseSignal(float.Parse(maskedTextBoxAmplitude.Text),
                        float.Parse(maskedTextBoxStartTime.Text),
                        float.Parse(maskedTextBoxDuration.Text),
                        int.Parse(maskedTextBoxFrequency.Text),
                        float.Parse(maskedTextBoxProbability.Text));

                    break;
            }

            if (signal != null)
            {
                ChartExistence[0] = true;
                ChartVisibility[0] = true;

                UpdateChartCollection();

                ShowCharts(ref chart1Real, collection, signal);

                ShowStats();
            }
        }

        private void ShowCharts (ref LiveCharts.WinForms.CartesianChart chart, 
            SeriesCollection collection, Signal signal)
        {
            chart.AxisX.Clear();
            chart.AxisY.Clear();

            chart.AxisX.Add(new Axis
            {
                Title = "t [s]",
                Foreground = System.Windows.Media.Brushes.Black,
                
            });

            chart.AxisY.Add(new Axis
            {
                Title = "A",
                Foreground = System.Windows.Media.Brushes.Black
            });

            chart.Series = collection;

            chart.LegendLocation = LegendLocation.Right;

            chart.Hoverable = false;
            chart.DisableAnimations = true;
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
            if (sampledSignal == null || maskedTextBoxQuantizationLevels.Text == "")
                return;

            quantizedSignal = new QuantizedSignal(sampledSignal.A, sampledSignal.t1, sampledSignal.d, sampledSignal.T,
                sampledSignal.f, sampledSignal.isContinuous,
                sampledSignal.PointsReal, int.Parse(maskedTextBoxQuantizationLevels.Text));

            ChartExistence[2] = ChartVisibility[2] = true;

            UpdateChartCollection();

        }

        private void buttonRecontruction_Click(object sender, EventArgs e)
        {
            ReconstructionOptions reconstructionOption =
                new ReconstructionOptions(signal, sampledSignal, quantizedSignal);

            reconstructionOption.ShowDialog();
        }

        private void buttonSample_Click(object sender, EventArgs e)
        {
            if (maskedTextBoxSampleFrequency.Text == "")
                return;


            if (signal == null)
            {
                buttonGenerateSignal_Click(null, null);
            }

            ChartExistence[2] = ChartVisibility[2] = false;

            sampledSignal = new SampledSignal(signal.A, signal.t1, signal.d, signal.T, signal.f, signal.isContinuous,
                signal.PointsReal, int.Parse(maskedTextBoxSampleFrequency.Text), signal.Func);

            ChartExistence[1] = ChartVisibility[1] = true;

            UpdateChartCollection();

        }

        private void buttonChartOptions_Click(object sender, EventArgs e)
        {
            ChartOptions chartOptions = new ChartOptions(ChartNames, ChartVisibility,
                ChartExistence, changeChartsVisibility);

            chartOptions.ShowDialog();
        }

        private void changeChartsVisibility(bool[] visibility)
        {
            ChartVisibility = visibility;

            UpdateChartCollection();
        }

        private void UpdateChartCollection()
        {
            if (collection == null)
                collection = new SeriesCollection();

            collection.Clear();

            for (int i = 0; i < 4; i++)
            {
                if (ChartVisibility[i])
                {
                    switch (i)
                    {
                        case 0:

                            if (signal != null)
                            {
                                if (signal.isContinuous)
                                {
                                    collection.Add(new LineSeries
                                    {
                                        Values = new ChartValues<ObservablePoint>(signal.GetRealPointsToChart()),
                                        PointForeground = null,
                                        PointGeometry = null,
                                        LineSmoothness = 0,
                                        Fill = System.Windows.Media.Brushes.Transparent,
                                        Title = ChartNames[0]
                                    }); 
                                }
                                else
                                {
                                    collection.Add(new LineSeries
                                    {
                                        Values = new ChartValues<ObservablePoint>(signal.GetRealPointsToChart()),

                                        PointGeometrySize = 8,
                                        Fill = System.Windows.Media.Brushes.Transparent,
                                        StrokeThickness = 0,
                                        Title = ChartNames[0]
                                    });
                                }

                                
                            }
                            
                            break;

                        case 1:

                            if (sampledSignal != null)
                                collection.Add(new LineSeries
                                {
                                    Values = new ChartValues<ObservablePoint>(sampledSignal.GetRealPointsToChart()),
                                    Stroke = System.Windows.Media.Brushes.Transparent,
                                    Fill = System.Windows.Media.Brushes.Transparent,
                                    Title = ChartNames[1]
                                });
                            

                            break;

                        case 2:

                            if (quantizedSignal != null)
                            {
                                
                                collection.Add(new StepLineSeries
                                {
                                    Values = new ChartValues<ObservablePoint>(quantizedSignal.GetRealPointsToChart()),
                                    PointGeometry = null,
                                    Title = ChartNames[2]
                                });
                                
                            }

                            break;

                        case 3:

                            if (reconstructedSignal != null)
                            {
                                if (reconstructedSignal.isContinuous)
                                    collection.Add(new LineSeries
                                    {
                                        Values = new ChartValues<ObservablePoint>(reconstructedSignal.GetRealPointsToChart()),
                                        PointForeground = null,
                                        PointGeometry = null,
                                        LineSmoothness = 0.7,
                                        Fill = System.Windows.Media.Brushes.Transparent,
                                        Title = ChartNames[3],
                                        
                                    });
                                else
                                    collection.Add(new LineSeries
                                    {
                                        Values = new ChartValues<ObservablePoint>(reconstructedSignal.GetRealPointsToChart()),
                                        
                                        PointGeometrySize = 8,
                                        Fill = System.Windows.Media.Brushes.Transparent,
                                        StrokeThickness = 0,
                                        Title = ChartNames[3]
                                    });
                            }

                            break;
                    }
                }
            }

            ShowCharts(ref chart1Real, collection, signal);
        }

        private void buttonShowCalculatedParams_Click(object sender, EventArgs e)
        {
            CalculatedParameters calculatedParameters = new CalculatedParameters(new Signal[]
            {
                signal, sampledSignal, quantizedSignal, reconstructedSignal
            }, ChartNames);

            calculatedParameters.Show();
        }

        private void SaveChart(LiveCharts.WinForms.CartesianChart chart)
        {
            Bitmap bmp = new Bitmap(chart.Width, chart.Height);
            chart.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));

            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "jpeg files (*.jpeg)|*.jpeg";
            saveFileDialog.FilterIndex = 0;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                bmp.Save(saveFileDialog.FileName, ImageFormat.Jpeg);
            }
        }

        private void buttonShowHistograms_Click(object sender, EventArgs e)
        {
            
            HistogramsWindow histogramsWindow = new HistogramsWindow(new Signal[]
            {
                signal, sampledSignal, quantizedSignal, reconstructedSignal
            }, ChartNames);

            histogramsWindow.Show();
        }

        private void buttonSaveChart_Click(object sender, EventArgs e)
        {
            SaveChart(chart1Real);
        }
    }
}
