namespace DSP
{
    partial class Simulator
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxTimeUnit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxObjectSpeed = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSignalSpeed = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPeriod = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxFrequency = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxBufforsLength = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxTimeToReport = new System.Windows.Forms.TextBox();
            this.buttonSimulation = new System.Windows.Forms.Button();
            this.cartesianChartBaseSignal = new LiveCharts.WinForms.CartesianChart();
            this.RealDistance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CalculatedDistance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DifferenceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonStop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RealDistance,
            this.CalculatedDistance,
            this.DifferenceColumn});
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Size = new System.Drawing.Size(473, 605);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBoxTimeUnit
            // 
            this.textBoxTimeUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxTimeUnit.Location = new System.Drawing.Point(732, 17);
            this.textBoxTimeUnit.Name = "textBoxTimeUnit";
            this.textBoxTimeUnit.Size = new System.Drawing.Size(168, 26);
            this.textBoxTimeUnit.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(492, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Jednostka czasowa [s]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(492, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Prędkość obiektu [jednostka/s]";
            // 
            // textBoxObjectSpeed
            // 
            this.textBoxObjectSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxObjectSpeed.Location = new System.Drawing.Point(732, 49);
            this.textBoxObjectSpeed.Name = "textBoxObjectSpeed";
            this.textBoxObjectSpeed.Size = new System.Drawing.Size(168, 26);
            this.textBoxObjectSpeed.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(492, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Prędkość rozchodzenia się sygnału [jednostka/s]";
            // 
            // textBoxSignalSpeed
            // 
            this.textBoxSignalSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxSignalSpeed.Location = new System.Drawing.Point(732, 81);
            this.textBoxSignalSpeed.Name = "textBoxSignalSpeed";
            this.textBoxSignalSpeed.Size = new System.Drawing.Size(168, 26);
            this.textBoxSignalSpeed.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(492, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Okres sygnału sondującego [s]";
            // 
            // textBoxPeriod
            // 
            this.textBoxPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxPeriod.Location = new System.Drawing.Point(732, 113);
            this.textBoxPeriod.Name = "textBoxPeriod";
            this.textBoxPeriod.Size = new System.Drawing.Size(168, 26);
            this.textBoxPeriod.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(492, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Częstotliwość próbkowania [Hz]";
            // 
            // textBoxFrequency
            // 
            this.textBoxFrequency.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxFrequency.Location = new System.Drawing.Point(732, 145);
            this.textBoxFrequency.Name = "textBoxFrequency";
            this.textBoxFrequency.Size = new System.Drawing.Size(168, 26);
            this.textBoxFrequency.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(492, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Długość buforów";
            // 
            // textBoxBufforsLength
            // 
            this.textBoxBufforsLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxBufforsLength.Location = new System.Drawing.Point(732, 177);
            this.textBoxBufforsLength.Name = "textBoxBufforsLength";
            this.textBoxBufforsLength.Size = new System.Drawing.Size(168, 26);
            this.textBoxBufforsLength.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(492, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Okres raportowania [s]";
            // 
            // textBoxTimeToReport
            // 
            this.textBoxTimeToReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxTimeToReport.Location = new System.Drawing.Point(732, 209);
            this.textBoxTimeToReport.Name = "textBoxTimeToReport";
            this.textBoxTimeToReport.Size = new System.Drawing.Size(168, 26);
            this.textBoxTimeToReport.TabIndex = 13;
            // 
            // buttonSimulation
            // 
            this.buttonSimulation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSimulation.Location = new System.Drawing.Point(919, 17);
            this.buttonSimulation.Name = "buttonSimulation";
            this.buttonSimulation.Size = new System.Drawing.Size(240, 62);
            this.buttonSimulation.TabIndex = 15;
            this.buttonSimulation.Text = "Symuluj";
            this.buttonSimulation.UseVisualStyleBackColor = true;
            this.buttonSimulation.Click += new System.EventHandler(this.buttonSimulation_Click);
            // 
            // cartesianChartBaseSignal
            // 
            this.cartesianChartBaseSignal.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cartesianChartBaseSignal.Location = new System.Drawing.Point(495, 241);
            this.cartesianChartBaseSignal.Name = "cartesianChartBaseSignal";
            this.cartesianChartBaseSignal.Size = new System.Drawing.Size(664, 377);
            this.cartesianChartBaseSignal.TabIndex = 16;
            this.cartesianChartBaseSignal.Text = "cartesianChart1";
            // 
            // RealDistance
            // 
            this.RealDistance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.RealDistance.HeaderText = "Rzeczywista odległość";
            this.RealDistance.Name = "RealDistance";
            this.RealDistance.ReadOnly = true;
            this.RealDistance.Width = 177;
            // 
            // CalculatedDistance
            // 
            this.CalculatedDistance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CalculatedDistance.HeaderText = "Obliczona odległość";
            this.CalculatedDistance.Name = "CalculatedDistance";
            this.CalculatedDistance.ReadOnly = true;
            this.CalculatedDistance.Width = 160;
            // 
            // DifferenceColumn
            // 
            this.DifferenceColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DifferenceColumn.HeaderText = "Różnica";
            this.DifferenceColumn.Name = "DifferenceColumn";
            this.DifferenceColumn.ReadOnly = true;
            this.DifferenceColumn.Width = 92;
            // 
            // buttonStop
            // 
            this.buttonStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonStop.Location = new System.Drawing.Point(919, 85);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(240, 62);
            this.buttonStop.TabIndex = 17;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // Simulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1450, 630);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.cartesianChartBaseSignal);
            this.Controls.Add(this.buttonSimulation);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxTimeToReport);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxBufforsLength);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxFrequency);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxPeriod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxSignalSpeed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxObjectSpeed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTimeUnit);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Simulator";
            this.Text = "Simulator";
            this.Load += new System.EventHandler(this.Simulator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxTimeUnit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxObjectSpeed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSignalSpeed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPeriod;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxFrequency;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxBufforsLength;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxTimeToReport;
        private System.Windows.Forms.Button buttonSimulation;
        private LiveCharts.WinForms.CartesianChart cartesianChartBaseSignal;
        private System.Windows.Forms.DataGridViewTextBoxColumn RealDistance;
        private System.Windows.Forms.DataGridViewTextBoxColumn CalculatedDistance;
        private System.Windows.Forms.DataGridViewTextBoxColumn DifferenceColumn;
        private System.Windows.Forms.Button buttonStop;
    }
}