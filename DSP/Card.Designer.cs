
namespace DSP
{
    partial class Card
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
            this.chart1Real = new LiveCharts.WinForms.CartesianChart();
            this.chart1Im = new LiveCharts.WinForms.CartesianChart();
            this.chart2Real = new LiveCharts.WinForms.CartesianChart();
            this.maskedTextBoxFrequency = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.maskedTextBoxProbability = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.maskedTextBoxJumpTime = new System.Windows.Forms.MaskedTextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.maskedTextBoxFilling = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxLength = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.maskedTextBoxStartTime = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBoxAmplitude = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonGenerateSignal = new System.Windows.Forms.Button();
            this.comboBoxSignalType = new System.Windows.Forms.ComboBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.comboBoxNumberOfSections = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1Real
            // 
            this.chart1Real.BackColor = System.Drawing.Color.DarkRed;
            this.chart1Real.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chart1Real.Location = new System.Drawing.Point(12, 12);
            this.chart1Real.Name = "chart1Real";
            this.chart1Real.Size = new System.Drawing.Size(410, 246);
            this.chart1Real.TabIndex = 0;
            this.chart1Real.Text = "cartesianChart1";
            // 
            // chart1Im
            // 
            this.chart1Im.BackColor = System.Drawing.Color.DarkRed;
            this.chart1Im.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chart1Im.Location = new System.Drawing.Point(12, 264);
            this.chart1Im.Name = "chart1Im";
            this.chart1Im.Size = new System.Drawing.Size(410, 246);
            this.chart1Im.TabIndex = 5;
            this.chart1Im.Text = "cartesianChart1";
            // 
            // chart2Real
            // 
            this.chart2Real.BackColor = System.Drawing.Color.ForestGreen;
            this.chart2Real.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chart2Real.Location = new System.Drawing.Point(428, 12);
            this.chart2Real.Name = "chart2Real";
            this.chart2Real.Size = new System.Drawing.Size(410, 246);
            this.chart2Real.TabIndex = 6;
            this.chart2Real.Text = "cartesianChart1";
            // 
            // maskedTextBoxFrequency
            // 
            this.maskedTextBoxFrequency.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.maskedTextBoxFrequency.Location = new System.Drawing.Point(293, 77);
            this.maskedTextBoxFrequency.Mask = "00.00";
            this.maskedTextBoxFrequency.Name = "maskedTextBoxFrequency";
            this.maskedTextBoxFrequency.Size = new System.Drawing.Size(53, 29);
            this.maskedTextBoxFrequency.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(3, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(274, 24);
            this.label9.TabIndex = 7;
            this.label9.Text = "Częstotliwość próbkowania [Hz]";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maskedTextBoxProbability
            // 
            this.maskedTextBoxProbability.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.maskedTextBoxProbability.Location = new System.Drawing.Point(293, 40);
            this.maskedTextBoxProbability.Mask = "00.00";
            this.maskedTextBoxProbability.Name = "maskedTextBoxProbability";
            this.maskedTextBoxProbability.Size = new System.Drawing.Size(53, 29);
            this.maskedTextBoxProbability.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(3, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(221, 24);
            this.label8.TabIndex = 5;
            this.label8.Text = "Prawdopodobieństwo (p)";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 24);
            this.label7.TabIndex = 4;
            this.label7.Text = "Czas skoku (ts)";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maskedTextBoxJumpTime
            // 
            this.maskedTextBoxJumpTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.maskedTextBoxJumpTime.Location = new System.Drawing.Point(293, 3);
            this.maskedTextBoxJumpTime.Mask = "00.00";
            this.maskedTextBoxJumpTime.Name = "maskedTextBoxJumpTime";
            this.maskedTextBoxJumpTime.Size = new System.Drawing.Size(53, 29);
            this.maskedTextBoxJumpTime.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.97561F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.02439F));
            this.tableLayoutPanel2.Controls.Add(this.maskedTextBoxJumpTime, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.maskedTextBoxProbability, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.maskedTextBoxFrequency, 1, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(429, 598);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.38272F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.61728F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(410, 113);
            this.tableLayoutPanel2.TabIndex = 11;
            // 
            // maskedTextBoxFilling
            // 
            this.maskedTextBoxFilling.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.maskedTextBoxFilling.Location = new System.Drawing.Point(279, 156);
            this.maskedTextBoxFilling.Mask = "00.00";
            this.maskedTextBoxFilling.Name = "maskedTextBoxFilling";
            this.maskedTextBoxFilling.Size = new System.Drawing.Size(53, 29);
            this.maskedTextBoxFilling.TabIndex = 12;
            // 
            // maskedTextBoxLength
            // 
            this.maskedTextBoxLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.maskedTextBoxLength.Location = new System.Drawing.Point(279, 113);
            this.maskedTextBoxLength.Mask = "00.00";
            this.maskedTextBoxLength.Name = "maskedTextBoxLength";
            this.maskedTextBoxLength.Size = new System.Drawing.Size(53, 29);
            this.maskedTextBoxLength.TabIndex = 8;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.maskedTextBox1.Location = new System.Drawing.Point(279, 75);
            this.maskedTextBox1.Mask = "00.00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(53, 29);
            this.maskedTextBox1.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(3, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Okres podstawowy (T) [s]";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(3, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Czas trwania sygnału (d) [s]";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maskedTextBoxStartTime
            // 
            this.maskedTextBoxStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.maskedTextBoxStartTime.Location = new System.Drawing.Point(279, 39);
            this.maskedTextBoxStartTime.Mask = "00.00";
            this.maskedTextBoxStartTime.Name = "maskedTextBoxStartTime";
            this.maskedTextBoxStartTime.Size = new System.Drawing.Size(53, 29);
            this.maskedTextBoxStartTime.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(3, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Czas początkowy (t1) (s)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Amplituda (A)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maskedTextBoxAmplitude
            // 
            this.maskedTextBoxAmplitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.maskedTextBoxAmplitude.Location = new System.Drawing.Point(279, 3);
            this.maskedTextBoxAmplitude.Mask = "00.00";
            this.maskedTextBoxAmplitude.Name = "maskedTextBoxAmplitude";
            this.maskedTextBoxAmplitude.Size = new System.Drawing.Size(53, 29);
            this.maskedTextBoxAmplitude.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(3, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(239, 43);
            this.label5.TabIndex = 11;
            this.label5.Text = "Współczynnik wypełnienia (kw)";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.56097F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.43903F));
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.maskedTextBoxAmplitude, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.maskedTextBoxStartTime, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.maskedTextBox1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.maskedTextBoxLength, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.maskedTextBoxFilling, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 515);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.38272F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.61728F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(410, 196);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // buttonGenerateSignal
            // 
            this.buttonGenerateSignal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonGenerateSignal.Location = new System.Drawing.Point(429, 358);
            this.buttonGenerateSignal.Name = "buttonGenerateSignal";
            this.buttonGenerateSignal.Size = new System.Drawing.Size(409, 57);
            this.buttonGenerateSignal.TabIndex = 12;
            this.buttonGenerateSignal.Text = "Generuj";
            this.buttonGenerateSignal.UseVisualStyleBackColor = true;
            // 
            // comboBoxSignalType
            // 
            this.comboBoxSignalType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxSignalType.FormattingEnabled = true;
            this.comboBoxSignalType.Items.AddRange(new object[] {
            "szum o rozkładzie jednostajnym",
            "szum gaussowski",
            "sygnał sinusoidalny",
            "sygnał sinusoidalny wyprostowany jednopołówkowo",
            "sygnał sinusoidalny wyprostowany dwupołówkowo",
            "sygnał prostokątny",
            "sygnał prostokątny symetryczny",
            "sygnał trójkątny",
            "skok jednostkowy",
            "impuls jednostkowy",
            "szum impulsowy"});
            this.comboBoxSignalType.Location = new System.Drawing.Point(429, 306);
            this.comboBoxSignalType.Name = "comboBoxSignalType";
            this.comboBoxSignalType.Size = new System.Drawing.Size(409, 28);
            this.comboBoxSignalType.TabIndex = 13;
            this.comboBoxSignalType.Text = "Wybierz typ sygnału";
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSave.Location = new System.Drawing.Point(429, 421);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(409, 57);
            this.buttonSave.TabIndex = 14;
            this.buttonSave.Text = "Zapisz";
            this.buttonSave.UseVisualStyleBackColor = true;
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
            this.comboBoxNumberOfSections.Location = new System.Drawing.Point(844, 12);
            this.comboBoxNumberOfSections.Name = "comboBoxNumberOfSections";
            this.comboBoxNumberOfSections.Size = new System.Drawing.Size(336, 28);
            this.comboBoxNumberOfSections.TabIndex = 15;
            this.comboBoxNumberOfSections.Text = "Wybierz liczbę przedziałów histogramu";
            // 
            // Card
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1253, 726);
            this.Controls.Add(this.comboBoxNumberOfSections);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.comboBoxSignalType);
            this.Controls.Add(this.buttonGenerateSignal);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.chart2Real);
            this.Controls.Add(this.chart1Im);
            this.Controls.Add(this.chart1Real);
            this.Name = "Card";
            this.Text = "Karta 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private LiveCharts.WinForms.CartesianChart chart1Real;
        private LiveCharts.WinForms.CartesianChart chart1Im;
        private LiveCharts.WinForms.CartesianChart chart2Real;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxFrequency;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxProbability;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxJumpTime;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxFilling;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxLength;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxStartTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxAmplitude;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonGenerateSignal;
        private System.Windows.Forms.ComboBox comboBoxSignalType;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.ComboBox comboBoxNumberOfSections;
    }
}

