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
        private Action<Signal, string, string> showTransformedSignalCallback;

        private Thread thread = null;

        private List<Card.SignalToShow> signals;

        private int selectedSignalIndex;
        private int selectedTransformationIndex;

        public Transformation(Action<Signal, string, string> showTransformedSignalCallback, List<Card.SignalToShow> signals)
        {
            InitializeComponent();
            this.showTransformedSignalCallback = showTransformedSignalCallback;
            this.signals = signals;

            comboBoxSignal.Items.AddRange(signals.Select(x => x.signalName).ToArray());

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

            if (signal.PointsReal.Count % 2 != 0)
            {
                signal.PointsReal.RemoveAt(signal.PointsReal.Count - 1);
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
                        object result = await TransformationManager.calculateDFT(signal.PointsReal);

                        this.Invoke(new Action(() => DisplayResult(result, signal, "Transformacja DFT")));
                    });

                    thread.Start();

                    break;

                case 1:

                    thread = new Thread(async delegate ()
                    {
                        object result = await TransformationManager.calculateFFT(signal.PointsReal);

                        this.Invoke(new Action(() => DisplayResult(result, signal, "Transformacja FFT")));
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

            showTransformedSignalCallback(newSignal, signals[selectedSignalIndex].signalName,
                transformationName);

            float timeElapsed = points.time;

            if (timeElapsed != 0)
            {
                richTextBoxTransformationInfo.Text = "Czas wykonania: " + timeElapsed + " ms";
            }
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
    }

    
}
