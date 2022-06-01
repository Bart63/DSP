using DSP.Signals;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.WinForms;
using LiveCharts.Wpf;
using LiveCharts.Wpf.Charts.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DSP.Simulation;
using System.Timers;
using System.Threading;

namespace DSP
{
    public partial class Simulator : Form
    {
        private Signal signal;
        private SeriesCollection collection;

        private Simulation.Object obj;
        private Simulation.Buffer bufferProbeSignal;
        private Simulation.Buffer bufferReceivedSignal;
        private float timeToUpdate;
        private float T;
        private int frequency;
        private float signalSpeed;

        private bool stop;
       
        

        public Simulator()
        {
            InitializeComponent();

            collection = new SeriesCollection();
            stop = false;
        }

        private void Simulator_Load(object sender, EventArgs e)
        {

        }

        private void buttonSimulation_Click(object sender, EventArgs e)
        {
            

            bool ok1 = float.TryParse(textBoxPeriod.Text, out T);
            bool ok2 = int.TryParse(textBoxFrequency.Text, out frequency);

            if (ok1 && ok2) 
            {

            }

            int bufferLength;

            bool ok3 = int.TryParse(textBoxBufforsLength.Text, out bufferLength);

            if (ok3)
            {

                obj = new Simulation.Object();

                bufferProbeSignal = new Simulation.Buffer(bufferLength);
                bufferReceivedSignal = new Simulation.Buffer(bufferLength);


                bool ok4 = float.TryParse(textBoxTimeToReport.Text, out timeToUpdate);

                if (ok4)
                {

                    bool ok5 = float.TryParse(textBoxSignalSpeed.Text, out signalSpeed);

                    if (ok5)
                    {

                        float speed;
                        bool ok6 = float.TryParse(textBoxObjectSpeed.Text, out speed);

                        if (ok6)
                        {
                            dataGridView1.Rows.Clear();

                            obj.speed = speed;

                            stop = false;

                            signal = GenerateSignal(0, T, ((float)((float)bufferReceivedSignal.length / frequency)));

                            showChart(ref cartesianChartBaseSignal, signal);

                            StartSimulating();
                        }
                    }
                }
            }

        }

        private Signal GenerateSignal(float t1, float T, float d)
        {
            Signal s1 = new SinSignal(2, t1, d, T, frequency);
            Signal s2 = new TrianSignal(1f, t1, d, T, frequency, 0.39f);

            return s1 * s2;
        }

        private async void StartSimulating()
        {
            while(!stop)
            {
                await Task.Delay(System.TimeSpan.FromSeconds(timeToUpdate));

                var v = await Simulate();

                showResult(v.real, v.calculated, v.diff);

                showChart(ref cartesianChartBaseSignal, v.receivedSignal);
            }
        }

        private async Task<(float real, float calculated, float diff, Signal receivedSignal)> Simulate()
        {
            obj.updateTime(timeToUpdate);
            obj.updateX();

            float duration = (float)bufferReceivedSignal.length / frequency;

            float propagationTime = 2 * obj.x / signalSpeed;


            Signal sReceived = GenerateSignal(0, T, obj.time - propagationTime + duration);
            bufferReceivedSignal.AddValues(sReceived.PointsReal.Where(
                x => x.X >= obj.time - propagationTime).ToList());

            Signal sProbe = GenerateSignal(obj.time - duration, T, duration);
            bufferProbeSignal.AddValues(sProbe.PointsReal);

            Signal s1 = new Signal(0, 0, 0, T, frequency, true, bufferProbeSignal.values, 
                null, Signal.SignalType.original, false);

            Signal s2 = new Signal(0, 0, 0, T, frequency, true, bufferReceivedSignal.values,
                null, Signal.SignalType.original, false);

            s1.PointsReal.Reverse();
            Signal s12 = s2.Convolution(s1);
            

            List<ObservablePoint> points = s12.PointsReal.Skip((s12.PointsReal.Count / 2)).ToList();

            int indexMax = points.Select(x => x.Y).ToList().IndexOf(points.Max(x => x.Y));

            float timeDifference = (float)indexMax / frequency;

            float calculatedDistance = timeDifference * signalSpeed / 2;

            float realDistance = obj.x;

            float diff = calculatedDistance - realDistance;

            return (realDistance, calculatedDistance, diff, s12);

        }

        private void showResult(float realDistance, float calculatedDistance, float diff)
        {
            dataGridView1.Rows.Add(realDistance, calculatedDistance, diff);
        }

        private void showChart(ref LiveCharts.WinForms.CartesianChart chart, Signal signal)
        {

            collection.Clear();
            collection.Add(new LineSeries
            {
                Values = new ChartValues<ObservablePoint>(signal.GetRealPointsToChart()),
                PointForeground = null,
                PointGeometry = null,
                LineSmoothness = 0,
                Fill = System.Windows.Media.Brushes.Transparent,
                Title = "Sygnał sondujący"
            });

            chart.Series = collection;

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

        private void buttonStop_Click(object sender, EventArgs e)
        {
            stop = true;
        }
    }
}
