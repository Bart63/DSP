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
    public partial class SaveSignal : Form
    {
        private List<Card.SignalToShow> signals;

        private int signalIndex;
        public SaveSignal(List<Card.SignalToShow> signals)
        {
            InitializeComponent();
            this.signals = signals;

            comboBoxSignal.Items.AddRange(signals.Select(x => x.signalName).ToArray());
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Signal s = signals[signalIndex].signal;

            bool result = FileManager.Save(s);

            if (result)
            {
                Close();
            }
        }

        private void comboBoxSignal_SelectedIndexChanged(object sender, EventArgs e)
        {
            signalIndex = comboBoxSignal.SelectedIndex;
        }
    }
}
