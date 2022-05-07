using DSP.Filters;
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
    public partial class FilterGenerator : Form
    {
        private Action<Filter> addFilterCallback;
        private Filter filter = null;
        private List<float> coefficients;
        private List<string> filtersNames;

        private int M;
        private int f0;

        private int fd, fg;

        string filterName = "";

        int sampleFrequency;

        List<string> names;

        public FilterGenerator(Action<Filter> addFilterCallback, List<string> filtersNames)
        {
            InitializeComponent();

            coefficients = new List<float>();
            this.addFilterCallback = addFilterCallback;
            this.filtersNames = filtersNames;

            names = new List<string>();
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            bool result = filtersNames.Contains(filterName) || names.Contains(filterName);

            if (result)
            {
                MessageBox.Show(this, "Błąd", "Nazwa już istnieje!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (coefficients.Count != 0 && filterName != "")
            {
                filter = new LowPassFilter(coefficients, filterName, sampleFrequency, f0);
                addFilterCallback(filter);
                MessageBox.Show(this, "Dodano filtr", "Super", MessageBoxButtons.OK, MessageBoxIcon.Information);
                names.Add(filterName);
            }
            else
            {
                MessageBox.Show(this, "Błąd", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        private void Calculate()
        {
            if (M == 0 || f0 == 0 || sampleFrequency == 0)
            {
                MessageBox.Show(this, "Błąd", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            coefficients = FilterOperations.GenerateLowPassFilter(sampleFrequency,
                M, f0, comboBoxFilterType.SelectedIndex);

            richTextBox1.Text = string.Join(" || ", coefficients.Select(x => x.ToString()));
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            Calculate();
        }


        private void comboBoxFilterType_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel.Controls.Clear();

            ComboBox comboBox = sender as ComboBox;
            Font font = new Font(FontFamily.GenericSansSerif, 14f, FontStyle.Bold);

            switch (comboBox.SelectedIndex)
            {
                case 0:

                    Label label = new Label();
                    label.Width = 350;
                    label.Text = "Rząd filtru:";
                    label.Font = font;
                    panel.Controls.Add(label);

                    TextBox textBox = new TextBox();
                    textBox.TextChanged += delegate (object s, EventArgs args)
                    {
                        TextBox textBox1 = s as TextBox;

                        bool result = int.TryParse(textBox1.Text, out M);

                        if (!result)
                            MessageBox.Show(this, "Błąd", "Tylko cyfry!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    };
                    textBox.Font = font;
                    panel.Controls.Add(textBox);
                        
                    label = new Label();
                    label.Text = "Pasmo odcięcia [Hz]:";
                    label.Width = 350;
                    label.Font = font;
                    panel.Controls.Add(label);

                    textBox = new TextBox();
                    textBox.TextChanged += delegate (object s, EventArgs args)
                    {
                        TextBox textBox1 = s as TextBox;

                        bool result = int.TryParse(textBox1.Text, out f0);

                        if (!result && textBox1.Text != "")
                            MessageBox.Show(this, "Błąd", "Tylko cyfry!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    };
                    textBox.Font = font;
                    panel.Controls.Add(textBox);


                    label = new Label();
                    label.Width = 350;
                    label.Text = "Nazwa filtru:";
                    label.Font = font;
                    panel.Controls.Add(label);

                    textBox = new TextBox();
                    textBox.TextChanged += delegate (object s, EventArgs args)
                    {
                        TextBox textBox1 = s as TextBox;

                        filterName = textBox1.Text;
                    };
                    textBox.Font = font;
                    panel.Controls.Add(textBox);

                    label = new Label();
                    label.Width = 350;
                    label.Text = "Częst. próbkowania [Hz]:";
                    label.Font = font;
                    panel.Controls.Add(label);

                    textBox = new TextBox();
                    textBox.TextChanged += delegate (object s, EventArgs args)
                    {
                        TextBox textBox1 = s as TextBox;

                        bool result = int.TryParse(textBox1.Text, out sampleFrequency);

                        if (!result && textBox1.Text != "")
                            MessageBox.Show(this, "Błąd", "Tylko cyfry!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    };
                    textBox.Font = font;
                    panel.Controls.Add(textBox);

                    break;

                case 1:


                    break;


                case 2:

                    break;

            
            }
        }
    }
}
