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
        private Action<bool[]> callback;
        private string[] charts;
        private bool[] visibility;
        private bool[] existing;
        public ChartOptions(string[] charts, bool[] visibility, bool[] existing, Action<bool[]> callback)
        {
            InitializeComponent();

            this.callback = callback;
            this.charts = charts;
            this.visibility = visibility;
            this.existing = existing;

            
        }

        private void change(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            int index = charts.ToList().FindIndex(x => x == checkBox.Text);

            visibility[index] = !visibility[index];

            
        }

        private void ChartOptions_Load(object sender, EventArgs e)
        {
            
            int i = 0;
            foreach (string s in charts)
            {
                if (existing[i])
                {
                    CheckBox checkBox = new CheckBox();
                    checkBox.Text = s;
                    checkBox.Checked = visibility[i];
                    checkBox.Width = 300;
                    checkBox.CheckedChanged += change;

                    flowLayoutPanel1.Controls.Add(checkBox);

                }
                i++;
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            callback(visibility);
            Close();
        }
    }
}
