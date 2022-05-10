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
using DSP.Filters;
using DSP.Helpers;
using DSP.Signals;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;


namespace DSP
{
    public partial class Card : Form
    {
        private Action<Card> removeCardCallback;

        SeriesCollection collection = null;

        private string[] chartsNames = new string[5] { "Sygnał oryginalny", "Sygnał spróbkowany",
        "Sygnał skwantyzowany", "Sygnał zrekonstruowany", "Sygnał przetworzony"};

        public class SignalToShow
        {
            public SignalToShow(Signal signal, bool visibility, string signalName)
            {
                this.signal = signal;
                this.visibility = visibility;
                this.signalName = signalName;
            }

            public Signal signal { get; set; }
            public bool visibility { get; set; }
            public string signalName { get; set; }


        }

        private List<Filter> filters;

        private List<SignalToShow> signals;

        public enum ParamsTypes
        {
            A, t1, d, T, basicFrequency, samplingFrequency, p, kw, numberOfFirstSample, ns, l, ts, k
        };

        private Dictionary<ParamsTypes, MaskedTextBox> paramsTextBoxes;

        public Card(int n, Action<Card> removeCardCallback)
        {
            InitializeComponent();

            signals = new List<SignalToShow>();
            filters = new List<Filter>();

            this.Text = "Karta " + n;

            this.removeCardCallback = removeCardCallback;

            maskedTextBoxFrequency.Text = "10000";

            DisableTextBoxes();
            SetParamsTextBoxes();

        }

        public Card(List<SignalToShow> signals)
        {
            InitializeComponent();
            
            this.signals = signals;
            filters = new List<Filter>();

            DisableTextBoxes();

            UpdateChartCollection();


            ShowStats();
            SetParamsTextBoxes();

        }
        
        private void ShowStats()
        {
            Signal s = signals.Find(x => x.signalName == "Sygnał oryginalny").signal;
            if (s == null)
                return;

            maskedTextBoxAmplitude.Text = s.A.ToString();
            maskedTextBoxDuration.Text = s.d.ToString();
            maskedTextBoxFrequency.Text = s.f.ToString();
            maskedTextBoxPeriod.Text = s.T.ToString();
            maskedTextBoxStartTime.Text = s.t1.ToString();
        }

        public Card(int n, Action<Card> removeCardCallback, Signal signal)
        {
            InitializeComponent();

            signals = new List<SignalToShow>();
            filters = new List<Filter>();

            signals.Add(new SignalToShow(signal, true, chartsNames[0]));

            Text = "Karta " + n;

            this.removeCardCallback = removeCardCallback;

            UpdateChartCollection();


            ShowStats();

            DisableTextBoxes();

            SetParamsTextBoxes();
        }

        public Signal GetSignal(Signal.SignalType type)
        {
            return signals.Find(x => x.signal.signalType == type)?.signal;
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
            Signal signal = null;

            for (int i = 1; i < 4; i++)
            {
                //ChartExistence[i] = ChartVisibility[i] = false;
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
                signals.Clear();

                signals.Add(new SignalToShow(signal, true, chartsNames[0]));

                UpdateChartCollection();

                ShowCharts(ref chart1Real, collection);

                ShowStats();
            }
        }

        private void ShowCharts (ref LiveCharts.WinForms.CartesianChart chart, 
            SeriesCollection collection)
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
            SignalToShow signal = signals.Find(x => x.signal.signalType == Signal.SignalType.original);

            if (signal != null)
            {
                FileManager.Save(signal.signal);
            }
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
            Signal sampledSignal = signals.Find(x => x.signal.signalType == Signal.SignalType.sampled)?.signal;
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

            Signal quantizedSignal = new QuantizedSignal(sampledSignal.A, sampledSignal.t1, sampledSignal.d, sampledSignal.T,
                sampledSignal.f, sampledSignal.isContinuous,
                sampledSignal.PointsReal, (int)values[0], sampledSignal.sampleFrequency);

            List<SignalToShow> oldSignals = signals.FindAll(x => x.signal.signalType == Signal.SignalType.quantized
                || x.signal.signalType == Signal.SignalType.reconstructed).ToList();

            if (oldSignals.Count > 0)
                signals.RemoveAll(x => oldSignals.Contains(x));

            
            signals.Add(new SignalToShow(quantizedSignal, true, chartsNames[2]));

            UpdateChartCollection();

        }

        private void buttonRecontruction_Click(object sender, EventArgs e)
        {
            Signal signal = signals.Find(x => x.signal.signalType == Signal.SignalType.original)?.signal;
            Signal sampledSignal = signals.Find(x => x.signal.signalType 
            == Signal.SignalType.sampled)?.signal;
            Signal quantizedSignal = signals.Find(x => x.signal.signalType == Signal.SignalType.quantized)?.signal;

            ReconstructionOptions reconstructionOption =
                new ReconstructionOptions(signal, sampledSignal, quantizedSignal, delegate (Signal reconstructed)
                {
                    
                    signals.Add(new SignalToShow(reconstructed, true,
                        (signals.Find(x => x.signal.signalType == Signal.SignalType.reconstructed) == null)
                        ? chartsNames[3] : chartsNames[3] + " 2"));

                    UpdateChartCollection();
                });

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

            Signal signal = signals.Find(x => x.signal.signalType == Signal.SignalType.original)?.signal;

            if (signal == null)
            {
                buttonGenerateSignal_Click(null, null);
            }

            signal = signals.Find(x => x.signal.signalType == Signal.SignalType.original)?.signal;

            if (signal == null)
                return;



            List<SignalToShow> oldSignals = signals.FindAll(x => x.signal.signalType == Signal.SignalType.sampled || 
            x.signal.signalType == Signal.SignalType.quantized || x.signal.signalType == Signal.SignalType.reconstructed).ToList();

            if (oldSignals.Count > 0)
                signals.RemoveAll(x => oldSignals.Contains(x));

            //ChartExistence[2] = ChartVisibility[2] = false;

            Signal sampledSignal = new SampledSignal(signal.A, signal.t1, signal.d, signal.T, signal.f, signal.isContinuous,
                signal.PointsReal, (int)values[0], signal.Func);

            //ChartExistence[1] = ChartVisibility[1] = true;

            signals.Add(new SignalToShow(sampledSignal, true, chartsNames[1]));

            UpdateChartCollection();

        }

        private void buttonChartOptions_Click(object sender, EventArgs e)
        {
            ChartOptions chartOptions = new ChartOptions(ref signals, changeChartsVisibility);

            chartOptions.ShowDialog();
        }

        private void changeChartsVisibility()
        {
            UpdateChartCollection();
        }

        private void UpdateChartCollection()
        {
            if (collection == null)
                collection = new SeriesCollection();
            else 
                collection.Clear();

            for (int i = 0; i < signals.Count; i++)
            {
                if (signals[i].visibility)
                {
                    switch (signals[i].signal.signalType)
                    {
                        case Signal.SignalType.original:

                            
                                if (signals[i].signal.isContinuous)
                                {
                                    collection.Add(new LineSeries
                                    {
                                        Values = new ChartValues<ObservablePoint>(signals[i].signal.GetRealPointsToChart()),
                                        PointForeground = null,
                                        PointGeometry = null,
                                        LineSmoothness = 0,
                                        Fill = System.Windows.Media.Brushes.Transparent,
                                        Title = signals[i].signalName
                                    }); 
                                }
                                else
                                {
                                    collection.Add(new LineSeries
                                    {
                                        Values = new ChartValues<ObservablePoint>(signals[i].signal.GetRealPointsToChart()),

                                        PointGeometrySize = 8,
                                        Fill = System.Windows.Media.Brushes.Transparent,
                                        StrokeThickness = 0,
                                        Title = signals[i].signalName
                                    });
                                }

                                
                            
                            
                            break;

                        case Signal.SignalType.sampled:

                            
                            collection.Add(new LineSeries
                            {
                                Values = new ChartValues<ObservablePoint>(signals[i].signal.GetRealPointsToChart()),
                                Stroke = System.Windows.Media.Brushes.Transparent,
                                Fill = System.Windows.Media.Brushes.Transparent,
                                Title = signals[i].signalName
                            });
                            

                            break;

                        case Signal.SignalType.quantized:

                            
                                
                            collection.Add(new StepLineSeries
                            {
                                Values = new ChartValues<ObservablePoint>(signals[i].signal.GetRealPointsToChart()),
                                PointGeometry = null,
                                Title = signals[i].signalName
                            });
                                
                            

                            break;

                        case Signal.SignalType.reconstructed:

                            
                            if (signals[i].signal.isContinuous)
                                collection.Add(new LineSeries
                                {
                                    Values = new ChartValues<ObservablePoint>(signals[i].signal.GetRealPointsToChart()),
                                    PointForeground = null,
                                    PointGeometry = null,
                                    LineSmoothness = 0.7,
                                    Fill = System.Windows.Media.Brushes.Transparent,
                                    Title = signals[i].signalName
                                        
                                });
                            else
                                collection.Add(new LineSeries
                                {
                                    Values = new ChartValues<ObservablePoint>(signals[i].signal.GetRealPointsToChart()),
                                        
                                    PointGeometrySize = 8,
                                    Fill = System.Windows.Media.Brushes.Transparent,
                                    StrokeThickness = 0,
                                    Title = signals[i].signalName
                                });
                            

                            break;

                        case Signal.SignalType.filtered:

                            if (signals[i].signal.isContinuous)
                                collection.Add(new LineSeries
                                {
                                    Values = new ChartValues<ObservablePoint>(signals[i].signal.GetRealPointsToChart()),
                                    PointForeground = null,
                                    PointGeometry = null,
                                    LineSmoothness = 0.7,
                                    Fill = System.Windows.Media.Brushes.Transparent,
                                    Title = signals[i].signalName

                                });
                            else
                                collection.Add(new LineSeries
                                {
                                    Values = new ChartValues<ObservablePoint>(signals[i].signal.GetRealPointsToChart()),

                                    PointGeometrySize = 8,
                                    Fill = System.Windows.Media.Brushes.Transparent,
                                    StrokeThickness = 0,
                                    Title = signals[i].signalName
                                });

                            break;
                    }
                }
            }

            ShowCharts(ref chart1Real, collection);
        }

        private void buttonShowCalculatedParams_Click(object sender, EventArgs e)
        {
            CalculatedParameters calculatedParameters = new CalculatedParameters(
                signals.Select(x => x.signal).ToArray(), signals.Select(x =>x.signalName).ToArray());

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
            
            HistogramsWindow histogramsWindow = new HistogramsWindow(signals.Select(x => x.signal).ToArray(),
                signals.Select(x => x.signalName).ToArray());

            histogramsWindow.Show();
        }

        private void buttonSaveChart_Click(object sender, EventArgs e)
        {
            SaveChart(chart1Real);
        }

        private void AddFilter(Filter filter)
        {
            filters.Add(filter);
        }

        private void buttonFilterGenerator_Click(object sender, EventArgs e)
        {
            FilterGenerator filterGenerator = new FilterGenerator(AddFilter, filters.Select(x => x.filterName).ToList());
            filterGenerator.ShowDialog();
        }

        private void buttonSignalFilter_Click(object sender, EventArgs e)
        {
            UseFilter useFilter = new UseFilter(filters, signals, AddFilteredSignal);
            useFilter.ShowDialog();
        }

        private void AddFilteredSignal(Signal signal, string originalSignalName, string filterName)
        {
            signals.Add(new SignalToShow(signal, true, chartsNames[4] + "[" + originalSignalName
                + " || " + filterName + "]"));
            UpdateChartCollection();
        }
    }
}
