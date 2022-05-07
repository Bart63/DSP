using DSP.Filters;
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
    public partial class UseFilter : Form
    {
        private List<Filter> filters;
        private List<Card.SignalToShow> signals;

        private Filter filter;
        private Card.SignalToShow signal;

        private Action<Signal, string, string> callback;
        
        public UseFilter(List<Filter> filters, List<Card.SignalToShow> signals, Action<Signal, string, string> callback)
        {
            InitializeComponent();

            this.filters = filters;
            this.signals = signals;
            this.callback = callback;

            comboBoxFilterType.Items.AddRange(filters.Select(x => x.filterName).ToArray());
            comboBoxSignal.Items.AddRange(signals.Select(x => x.signalName).ToArray());
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            if (filter == null || signal == null)
            {
                MessageBox.Show(this, "Błąd", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Signal s = signal.signal;

            Signal newSignal = new Signal(0, s.t1, s.d, s.T, s.f, s.isContinuous,
                filter.GetFilteredSignal(s.PointsReal.Select(x => (float)x.Y).ToList(), s.t1),
                null, Signal.SignalType.filtered);

            callback(newSignal, signal.signalName, filter.filterName);

            Close();
        }

        private void comboBoxFilterType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;

            filter = filters.Find(x => x.filterName == comboBox.Text);

            richTextBox1.Text = filter.GetInfo();
        }

        private void comboBoxSignal_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;

            signal = signals.Find(x => x.signalName == comboBox.Text);

        }
    }
}
