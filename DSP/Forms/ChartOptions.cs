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
        string[] charts;
        bool[] visibility;
        public ChartOptions(string[] charts, bool[] visibility, bool[] existing, Action<bool[]> callback)
        {
            InitializeComponent();

            this.callback = callback;
            this.charts = charts;
            this.visibility = visibility;

            int i = 0;
            foreach(string s in charts)
            {
                if (existing[i])
                {
                    CheckBox checkBox = new CheckBox();
                    checkBox.Text = s;
                    checkBox.Checked = visibility[i];
                    checkBox.CheckedChanged += change;
                    panel1.Container.Add(checkBox);
                    
                }
                i++;
            }
        }

        private void change(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            int index = charts.ToList().FindIndex(x => x == checkBox.Text);

            visibility[index] = !visibility[index];

            
        }

        private void ChartOptions_Load(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            callback(visibility);
            Close();
        }
    }
}
