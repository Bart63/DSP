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
        private Signal basicSignal;
        private SampledSignal sampledSignal;
        private QuantizedSignal quantizedSignal;

        public ReconstructionOptions(Signal basicSignal, SampledSignal signal,
            QuantizedSignal quantizedSignal)
        {
            
            InitializeComponent();

            this.sampledSignal = signal;
            this.quantizedSignal = quantizedSignal;
            this.basicSignal = basicSignal;

            comboBoxSignalToReconstruct.Items.Add("Sygnał spróbkowany");

            if (quantizedSignal != null)
            {
                comboBoxSignalToReconstruct.Items.Add("Sygnał skwantowany");
            }
        }

        private void buttonRecontruction_Click(object sender, EventArgs e)
        {
            ReconstructedSignal reconstructedSignal = null;
            switch (comboBoxSignalToReconstruct.SelectedIndex)
            {
                case 1:

                    reconstructedSignal = new ReconstructedSignal(quantizedSignal.A, quantizedSignal.t1, quantizedSignal.d,
                quantizedSignal.T, quantizedSignal.isContinuous, comboBoxReconstructionType.SelectedIndex,
                quantizedSignal.quantizationLevels, quantizedSignal.f, quantizedSignal.PointsReal, null, basicSignal.PointsReal, 
                comboBoxReconstructionType.SelectedIndex == 0 ? 0 : int.Parse(maskedTextBoxNumberOfSamplesSinc.Text));

                    

                    break;

                case 0:

                    reconstructedSignal = new ReconstructedSignal(sampledSignal.A, sampledSignal.t1, sampledSignal.d,
                sampledSignal.T, sampledSignal.isContinuous, comboBoxReconstructionType.SelectedIndex,
                sampledSignal.sampleFrequency, sampledSignal.f, sampledSignal.PointsReal, basicSignal.PointsReal, null,
                comboBoxReconstructionType.SelectedIndex == 0 ? 0 : int.Parse(maskedTextBoxNumberOfSamplesSinc.Text));

                    

                    break;
            }

            Card card = new Card(basicSignal, sampledSignal, quantizedSignal, reconstructedSignal);
            card.Show();
        }
    }
}
