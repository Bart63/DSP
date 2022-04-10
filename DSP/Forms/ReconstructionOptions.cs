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


namespace DSP
{
    public partial class ReconstructionOptions : Form
    {
        private SampledSignal signal;
        private QuantizedSignal quantizedSignal;

        public ReconstructionOptions(SampledSignal signal, QuantizedSignal quantizedSignal)
        {
            
            InitializeComponent();

            this.signal = signal;
            this.quantizedSignal = quantizedSignal;

            comboBoxSignalToReconstruct.Items.Add("Sygnał spróbkowany");

            if (quantizedSignal != null)
            {
                comboBoxSignalToReconstruct.Items.Add("Sygnał skwantowany");
            }
        }

        private void buttonRecontruction_Click(object sender, EventArgs e)
        {
            ReconstructedSignal reconstructedSignal = null;
            Card card = null;

            switch (comboBoxSignalToReconstruct.SelectedIndex)
            {
                case 1:

                    reconstructedSignal = new ReconstructedSignal(quantizedSignal.A, quantizedSignal.t1, quantizedSignal.d,
                quantizedSignal.T, quantizedSignal.isContinuous, comboBoxReconstructionType.SelectedIndex,
                quantizedSignal.quantizationLevels, quantizedSignal.f, quantizedSignal.PointsReal, null,
                comboBoxReconstructionType.SelectedIndex == 0 ? 0 : int.Parse(maskedTextBoxNumberOfSamplesSinc.Text));

                    card = new Card(quantizedSignal, reconstructedSignal);

                    break;

                case 0:

                    reconstructedSignal = new ReconstructedSignal(signal.A, signal.t1, signal.d,
                signal.T, signal.isContinuous, comboBoxReconstructionType.SelectedIndex,
                signal.f, signal.f, signal.PointsReal, null,
                comboBoxReconstructionType.SelectedIndex == 0 ? 0 : int.Parse(maskedTextBoxNumberOfSamplesSinc.Text));

                    card = new Card(signal, reconstructedSignal);

                    break;
            }


            card.Show();
        }
    }
}
