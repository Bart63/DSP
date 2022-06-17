using DSP.Helpers;
using DSP.Signals;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using LiveCharts.Defaults;

namespace DSP
{
    public partial class Transformation : Form
    {
        private Action<Signal, string, string, Action<List<Card.SignalToShow>>> showTransformedSignalCallback;

        private Thread thread = null;

        private List<Card.SignalToShow> signals;

        private int selectedSignalIndex;
        private int selectedTransformationIndex;

        public Transformation(Action<Signal, string, string, Action<List<Card.SignalToShow>>> showTransformedSignalCallback, List<Card.SignalToShow> signals)
        {
            InitializeComponent();
            this.showTransformedSignalCallback = showTransformedSignalCallback;
            UpdateSignalsList(signals);

            TransformationManager.SetCallback(DisplayPercentOfCompletion);
        }

        private void DisplayPercentOfCompletion(float value)
        {
            this.Invoke(new Action(() => ShowPercentOfCompletion(value)));
        }

        private void comboBoxTransformationType_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedTransformationIndex = comboBoxTransformationType.SelectedIndex;
        }

        private void comboBoxSignal_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedSignalIndex = comboBoxSignal.SelectedIndex;
        }

        private async void buttonTransform_Click(object sender, EventArgs e)
        {
            Signal signal = signals[selectedSignalIndex].signal;

            bool stop = false;
            for (int i = 1; i <= 10; i++)
            {
                float value = (float)Math.Pow(2, i);

                if (signal.PointsReal.Count == value)
                    break;

                if (signal.PointsReal.Count < value || i == 10)
                {
                    float newValue = i != 10 ? (float)Math.Pow(2, i - 1) : (float)Math.Pow(2, 10);

                    MessageBox.Show("Ilość próbek została okrojona do: " + newValue + " co odpowiada 2^" + (i != 10 ? (i - 1) : i),
                        "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    while(signal.PointsReal.Count > newValue)
                    {
                        signal.PointsReal.RemoveAt(signal.PointsReal.Count - 1);
                    }
                    while (signal.PointsIm.Count > newValue)
                    {
                        signal.PointsIm.RemoveAt(signal.PointsIm.Count - 1);
                    }

                    stop = true;
                    break;
                }

                if (stop)
                    break;
            }

            if (thread != null)
            {
                if (thread.IsAlive)
                {
                    if (MessageBox.Show("Liczę! Chcesz zakończyć proces i zacząć nowy?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        thread.Abort();
                    }
                    else
                        return;
                }
            }


            switch (selectedTransformationIndex)
            {
                case 0:

                    thread = new Thread(async delegate ()
                    {
                        object result = await TransformationManager.calculateDFT(signal.PointsReal, signal.PointsIm);

                        this.Invoke(new Action(() => DisplayResult(result, signal, "Transformacja DFT")));
                    });

                    thread.Start();

                    break;

                case 1:

                    thread = new Thread(async delegate ()
                    {
                        object result = await TransformationManager.calculateFFT(signal.PointsReal, signal.PointsIm);

                        this.Invoke(new Action(() => DisplayResult(result, signal, "Transformacja FFT")));
                    });

                    thread.Start();

                    break;

                case 2:

                    thread = new Thread(async delegate ()
                    {
                        object result = await TransformationManager.calculateDCTII(signal.PointsReal);

                        this.Invoke(new Action(() => DisplayResult(result, signal, "Transformacja DCT II")));
                    });

                    thread.Start();

                    break;

                case 3:

                    thread = new Thread(async delegate ()
                    {
                        object result = await TransformationManager.calculateFCT(signal.PointsReal);

                        this.Invoke(new Action(() => DisplayResult(result, signal, "Transformacja FCT II")));
                    });

                    thread.Start();

                    break;


                case 4:

                    thread = new Thread(async delegate ()
                    {
                        object result = await TransformationManager.calculateIDFT(signal.PointsReal, signal.PointsIm);

                        this.Invoke(new Action(() => DisplayResult(result, signal, "Transformacja I-DFT")));
                    });

                    thread.Start();

                    break;

                case 5:

                    thread = new Thread(async delegate ()
                    {
                        object result = await TransformationManager.calculateIFFT(signal.PointsReal, signal.PointsIm);

                        this.Invoke(new Action(() => DisplayResult(result, signal, "Transformacja I-FFT")));
                    });

                    thread.Start();

                    break;

                case 6:

                    thread = new Thread(async delegate ()
                    {
                        object result = await TransformationManager.calculateIFFT(signal.PointsReal, signal.PointsIm);

                        this.Invoke(new Action(() => DisplayResult(result, signal, "Transformacja I-DCT II")));
                    });

                    thread.Start();

                    break;

                case 7:

                    thread = new Thread(async delegate ()
                    {
                        object result = await TransformationManager.calculateIFCT(signal.PointsReal);

                        this.Invoke(new Action(() => DisplayResult(result, signal, "Transformacja I-FCT II")));
                    });

                    thread.Start();

                    break;
            }

            
        }

        private void ShowPercentOfCompletion(float percent)
        {
            richTextBoxTransformationInfo.Text = "Ukończono: " + percent + "%";
        }

        private void DisplayResult(object result, Signal signal, string transformationName)
        {

            var points = ((List<ObservablePoint> resultReal, List<ObservablePoint> resultIm, float time))result;

            Signal newSignal = new Signal(signal.A, signal.t1, signal.d, signal.T, signal.f,
                signal.isContinuous, points.resultReal, points.resultIm, Signal.SignalType.original);

            newSignal.isComplex = true;

            showTransformedSignalCallback(newSignal, signals[selectedSignalIndex].signalName,
                transformationName, UpdateSignalsList);

            float timeElapsed = points.time;

            richTextBoxTransformationInfo.Text = "Czas wykonania: " + timeElapsed + " ms";
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            if (thread != null)
            {
                if (thread.IsAlive)
                {
                    thread.Abort();
                    richTextBoxTransformationInfo.AppendText("\nZatrzymano");
                }
                else
                {
                    MessageBox.Show("Nie ma czego zatrzymywać");
                }
                
            }
            else
                MessageBox.Show("Nie ma czego zatrzymywać");
        }

        public void UpdateSignalsList(List<Card.SignalToShow> signals)
        {
            this.signals = signals;

            comboBoxSignal.Items.Clear();
            comboBoxSignal.Items.AddRange(signals.Select(x => x.signalName).ToArray());
        }
    }

}
