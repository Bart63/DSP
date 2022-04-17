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

namespace DSP
{
    public partial class CalculatedParameters : Form
    {
        string[] names;
        Signal[] signals;
        public CalculatedParameters(Signal[] signals, string[] names)
        {
            InitializeComponent();

            this.signals = signals;
            this.names = names;

            for (int i = 0; i < 4; i++)
            {
                if (signals[i] != null)
                    comboBoxSignalType.Items.Add(names[i]);
            }

            if (comboBoxSignalType.Items.Count != 0)
            {
                comboBoxSignalType.SelectedIndex = 0;

                comboBoxSignalType_SelectedIndexChanged(null, null);
            }
        }

        private void comboBoxSignalType_SelectedIndexChanged(object sender, EventArgs e)
        {

            Signal s = null;

            for (int i = 0; i < 4; i++)
            {
                if (names[i] == comboBoxSignalType.SelectedItem.ToString())
                {
                    s = signals[i];

                }
            }

            if (s == null)
                return;

            TextBoxAverageSignal.Text = s.AverageSignalValue.ToString();
            TextBoxAverageAbsSignal.Text = s.AverageSignalAbsValue.ToString();
            TextBoxAveragePower.Text = s.AverageSignalPower.ToString();
            TextBoxVariance.Text = s.Variance.ToString();
            TextBoxEffectiveValue.Text = s.EffectiveValue.ToString();

            textBoxMeanSquareError.Text = s.MSE.ToString();
            textBoxSignalNoiseRatio.Text = s.SNR.ToString();
            textBoxHighestSignalNoiseRatio.Text = s.PSNR.ToString();
            textBoxMaxDifference.Text = s.MD.ToString();
            textBoxENOB.Text = s.ENOB.ToString();
        }
    }
}
