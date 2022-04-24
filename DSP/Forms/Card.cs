using System;
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
        
        public enum ParamsTypes
        {
            A, t1, d, T, basicFrequency, samplingFrequency, p, kw, numberOfFirstSample, ns, l, ts, k
        };

        private Dictionary<ParamsTypes, MaskedTextBox> paramsTextBoxes;

        public Card(int n, Action<Card> removeCardCallback)
        {
            InitializeComponent();

            this.Text = "Karta " + n;

            this.removeCardCallback = removeCardCallback;

            maskedTextBoxFrequency.Text = "10000";

            DisableTextBoxes();
            SetParamsTextBoxes();

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
            SetParamsTextBoxes();

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

            SetParamsTextBoxes();
        }

        private void SetParamsTextBoxes()
        {
            paramsTextBoxes = new Dictionary<ParamsTypes, MaskedTextBox>();

            paramsTextBoxes.Add(ParamsTypes.A, maskedTextBoxAmplitude);
            paramsTextBoxes.Add(ParamsTypes.basicFrequency, maskedTextBoxFrequency);
            paramsTextBoxes.Add(ParamsTypes.d, maskedTextBoxDuration);
            paramsTextBoxes.Add(ParamsTypes.k, maskedTextBoxQuantizationLevels);
            paramsTextBoxes.Add(ParamsTypes.kw, maskedTextBoxFilling);
            paramsTextBoxes.Add(ParamsTypes.l, maskedTextBoxNuberOfSamples);
            paramsTextBoxes.Add(ParamsTypes.ns, maskedTextBoxSampleNumber);
            paramsTextBoxes.Add(ParamsTypes.numberOfFirstSample, maskedTextBoxFirstSampleNumber);
            paramsTextBoxes.Add(ParamsTypes.p, maskedTextBoxProbability);
            paramsTextBoxes.Add(ParamsTypes.samplingFrequency, maskedTextBoxSampleFrequency);
            paramsTextBoxes.Add(ParamsTypes.T, maskedTextBoxPeriod);
            paramsTextBoxes.Add(ParamsTypes.t1, maskedTextBoxStartTime);
            paramsTextBoxes.Add(ParamsTypes.ts, maskedTextBoxJumpTime);
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


        private bool ParseToNum(ref float value, string text)
        {
            return float.TryParse(text, out value);
        }

        private void ShowErrorBox(string text)
        {
            MessageBox.Show(this, "Błąd", text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private float[] GetParams(ParamsTypes[] paramsTypes, ref bool result)
        {
            float[] values = new float[paramsTypes.Length];

            result = true;

            int i = 0;
            foreach (var item in paramsTypes)
            {
                if (!ParseToNum(ref values[i], paramsTextBoxes[item].Text))
                {
                    result = false;
                    return null;
                }

                i++;
            }

            return values;
        }
        
        private void buttonGenerateSignal_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 4; i++)
            {
                ChartExistence[i] = ChartVisibility[i] = false;
            }

            bool result = false;

            switch (comboBoxSignalType.SelectedIndex)
            {
                case 0:


                    float[] values = GetParams(new ParamsTypes[] { ParamsTypes.A, ParamsTypes.t1, ParamsTypes.d, ParamsTypes.basicFrequency },
                        ref result);

                    if (!result)
                    {
                        ShowErrorBox("Nieprawidłowe wartości!");
                        return;
                    }
                    
                    signal = new NoiseSignal(values[0], values[1], values[2], (int)values[3]);

                    
                    break;

                case 1:

                    values = GetParams(new ParamsTypes[] { ParamsTypes.A, ParamsTypes.t1, ParamsTypes.d, ParamsTypes.basicFrequency },
                       ref result);

                    if (!result)
                    {
                        ShowErrorBox("Nieprawidłowe wartości!");
                        return;
                    }

                    signal = new GaussianNoiseSignal(values[0], values[1], values[2], (int)values[3]);



                    break;


                case 2:

                    values = GetParams(new ParamsTypes[] { ParamsTypes.A, ParamsTypes.t1, ParamsTypes.d, ParamsTypes.T, ParamsTypes.basicFrequency },
                       ref result);

                    if (!result)
                    {
                        ShowErrorBox("Nieprawidłowe wartości!");
                        return;
                    }

                    signal = new SinSignal(values[0], values[1], values[2], values[3], (int)values[4]);

                    
                    break;

                case 3:

                    values = GetParams(new ParamsTypes[] { ParamsTypes.A, ParamsTypes.t1, ParamsTypes.d, ParamsTypes.T, ParamsTypes.basicFrequency },
                       ref result);

                    if (!result)
                    {
                        ShowErrorBox("Nieprawidłowe wartości!");
                        return;
                    }

                    signal = new SinSignal2(values[0], values[1], values[2], values[3], (int)values[4]);

                    break;

                case 4:

                    values = GetParams(new ParamsTypes[] { ParamsTypes.A, ParamsTypes.t1, ParamsTypes.d, ParamsTypes.T, ParamsTypes.basicFrequency },
                       ref result);

                    if (!result)
                    {
                        ShowErrorBox("Nieprawidłowe wartości!");
                        return;
                    }

                    signal = new SinSignal3(values[0], values[1], values[2], values[3], (int)values[4]);


                    break;

                case 5:

                    values = GetParams(new ParamsTypes[] { ParamsTypes.A, ParamsTypes.t1, ParamsTypes.d, ParamsTypes.T, ParamsTypes.basicFrequency,
                    ParamsTypes.kw}, ref result);

                    if (!result)
                    {
                        ShowErrorBox("Nieprawidłowe wartości!");
                        return;
                    }

                    signal = new RectSignal(values[0], values[1], values[2], values[3], (int)values[4], values[5]);

                    
                    break;

                case 6:

                    values = GetParams(new ParamsTypes[] { ParamsTypes.A, ParamsTypes.t1, ParamsTypes.d, ParamsTypes.T, ParamsTypes.basicFrequency,
                    ParamsTypes.kw}, ref result);

                    if (!result)
                    {
                        ShowErrorBox("Nieprawidłowe wartości!");
                        return;
                    }

                    signal = new RectSimSignal(values[0], values[1], values[2], values[3], (int)values[4], values[5]);


                    break;

                case 7:

                    values = GetParams(new ParamsTypes[] { ParamsTypes.A, ParamsTypes.t1, ParamsTypes.d, ParamsTypes.T, ParamsTypes.basicFrequency,
                    ParamsTypes.kw}, ref result);

                    if (!result)
                    {
                        ShowErrorBox("Nieprawidłowe wartości!");
                        return;
                    }

                    signal = new TrianSignal(values[0], values[1], values[2], values[3], (int)values[4], values[5]);

                    break;

                case 8:

                    values = GetParams(new ParamsTypes[] { ParamsTypes.A, ParamsTypes.t1, ParamsTypes.d, ParamsTypes.basicFrequency,
                    ParamsTypes.ts}, ref result);

                    if (!result)
                    {
                        ShowErrorBox("Nieprawidłowe wartości!");
                        return;
                    }

                    signal = new UnitJumpSignal(values[0], values[1], values[2], (int)values[3], values[4]);


                    break;

                case 9:

                    values = GetParams(new ParamsTypes[] { ParamsTypes.A, ParamsTypes.numberOfFirstSample, ParamsTypes.l, ParamsTypes.basicFrequency,
                    ParamsTypes.ns}, ref result);

                    if (!result)
                    {
                        ShowErrorBox("Nieprawidłowe wartości!");
                        return;
                    }

                    signal = new UnitImpulseSignal(values[0], (int)values[1], (int)values[2], (int)values[3], (int)values[4]);

                    
                    break;


                case 10:

                    values = GetParams(new ParamsTypes[] { ParamsTypes.A, ParamsTypes.t1, ParamsTypes.d, ParamsTypes.basicFrequency,
                    ParamsTypes.p}, ref result);

                    if (!result)
                    {
                        ShowErrorBox("Nieprawidłowe wartości!");
                        return;
                    }

                    signal = new ImpulseNoiseSignal(values[0], values[1], values[2], (int)values[3], values[4]);

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
            if (sampledSignal == null)
            {
                ShowErrorBox("Brak sygnału!");
                return;
            }

            bool result = false;
            float[] values = GetParams(new ParamsTypes[] { ParamsTypes.k }, ref result);

            if (!result)
            {
                ShowErrorBox("Nieprawidłowa wartość!");
                return;
            }

            quantizedSignal = new QuantizedSignal(sampledSignal.A, sampledSignal.t1, sampledSignal.d, sampledSignal.T,
                sampledSignal.f, sampledSignal.isContinuous,
                sampledSignal.PointsReal, (int)values[0]);

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
            bool result = false;
            float[] values = GetParams(new ParamsTypes[] { ParamsTypes.samplingFrequency }, ref result);
            
            if (!result)
            {
                ShowErrorBox("Nieprawidłowe wartości!");
                return;
            }

            if (signal == null)
            {
                buttonGenerateSignal_Click(null, null);
            }

            if (signal == null)
                return;

            ChartExistence[2] = ChartVisibility[2] = false;

            sampledSignal = new SampledSignal(signal.A, signal.t1, signal.d, signal.T, signal.f, signal.isContinuous,
                signal.PointsReal, (int)values[0], signal.Func);

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
