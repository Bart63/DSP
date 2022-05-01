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
    public partial class ChartOptions : Form
    {
        private Action callback;
        private List<Card.SignalToShow> signals;
        public ChartOptions(ref List<Card.SignalToShow> signals, Action callback)
        {
            InitializeComponent();

            this.callback = callback;
            this.signals = signals;
        }

        private void change(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            int index = signals.ToList().FindIndex(x => x.signalName == checkBox.Text);

            signals[index].visibility = !signals[index].visibility;

        }

        private void ChartOptions_Load(object sender, EventArgs e)
        {
            
            int i = 0;
            foreach (string s in signals.Select(x => x.signalName))
            {
                
                CheckBox checkBox = new CheckBox();
                checkBox.Text = s;
                checkBox.Checked = signals[i].visibility;
                checkBox.Width = 300;
                checkBox.CheckedChanged += change;

                flowLayoutPanel1.Controls.Add(checkBox);

                i++;
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            callback();
            Close();
        }
    }
}
