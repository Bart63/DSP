
namespace DSP
{
    partial class HistogramsWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxSignalType = new System.Windows.Forms.ComboBox();
            this.chart1 = new LiveCharts.WinForms.CartesianChart();
            this.chart2 = new LiveCharts.WinForms.CartesianChart();
            this.comboBoxNumberOfSections = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBoxSignalType
            // 
            this.comboBoxSignalType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxSignalType.FormattingEnabled = true;
            this.comboBoxSignalType.Location = new System.Drawing.Point(12, 12);
            this.comboBoxSignalType.Name = "comboBoxSignalType";
            this.comboBoxSignalType.Size = new System.Drawing.Size(376, 32);
            this.comboBoxSignalType.TabIndex = 21;
            this.comboBoxSignalType.Text = "Wybierz sygnał";
            this.comboBoxSignalType.SelectedIndexChanged += new System.EventHandler(this.comboBoxSignalType_SelectedIndexChanged);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.ForestGreen;
            this.chart1.BackColorTransparent = true;
            this.chart1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chart1.Location = new System.Drawing.Point(12, 109);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(421, 234);
            this.chart1.TabIndex = 22;
            this.chart1.Text = "cartesianChart1";
            // 
            // chart2
            // 
            this.chart2.BackColor = System.Drawing.Color.ForestGreen;
            this.chart2.BackColorTransparent = true;
            this.chart2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chart2.Location = new System.Drawing.Point(439, 109);
            this.chart2.Name = "chart2";
            this.chart2.Size = new System.Drawing.Size(421, 234);
            this.chart2.TabIndex = 23;
            this.chart2.Text = "cartesianChart1";
            // 
            // comboBoxNumberOfSections
            // 
            this.comboBoxNumberOfSections.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxNumberOfSections.FormattingEnabled = true;
            this.comboBoxNumberOfSections.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20"});
            this.comboBoxNumberOfSections.Location = new System.Drawing.Point(451, 15);
            this.comboBoxNumberOfSections.Name = "comboBoxNumberOfSections";
            this.comboBoxNumberOfSections.Size = new System.Drawing.Size(409, 28);
            this.comboBoxNumberOfSections.TabIndex = 24;
            this.comboBoxNumberOfSections.Text = "Wybierz liczbę przedziałów histogramu";
            this.comboBoxNumberOfSections.SelectedIndexChanged += new System.EventHandler(this.comboBoxNumberOfSections_SelectedIndexChanged);
            // 
            // HistogramsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 356);
            this.Controls.Add(this.comboBoxNumberOfSections);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.comboBoxSignalType);
            this.Name = "HistogramsWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "HistogramsWindow";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSignalType;
        private LiveCharts.WinForms.CartesianChart chart1;
        private LiveCharts.WinForms.CartesianChart chart2;
        private System.Windows.Forms.ComboBox comboBoxNumberOfSections;
    }
}