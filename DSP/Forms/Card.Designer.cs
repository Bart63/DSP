
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
            this.label14 = new System.Windows.Forms.Label();
            this.maskedTextBoxSampleNumber = new System.Windows.Forms.MaskedTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.maskedTextBoxFirstSampleNumber = new System.Windows.Forms.MaskedTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.maskedTextBoxNuberOfSamples = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxFilling = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.maskedTextBoxStartTime = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBoxAmplitude = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.maskedTextBoxDuration = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxPeriod = new System.Windows.Forms.MaskedTextBox();
            this.buttonGenerateSignal = new System.Windows.Forms.Button();
            this.comboBoxSignalType = new System.Windows.Forms.ComboBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.comboBoxNumberOfSections = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TextBoxAverageSignal = new System.Windows.Forms.TextBox();
            this.TextBoxAverageAbsSignal = new System.Windows.Forms.TextBox();
            this.TextBoxAveragePower = new System.Windows.Forms.TextBox();
            this.TextBoxVariance = new System.Windows.Forms.TextBox();
            this.TextBoxEffectiveValue = new System.Windows.Forms.TextBox();
            this.chart2Im = new LiveCharts.WinForms.CartesianChart();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.textBoxMeanSquareError = new System.Windows.Forms.TextBox();
            this.textBoxSignalNoiseRatio = new System.Windows.Forms.TextBox();
            this.textBoxHighestSignalNoiseRatio = new System.Windows.Forms.TextBox();
            this.textBoxMaxDifference = new System.Windows.Forms.TextBox();
            this.buttonRecontruction = new System.Windows.Forms.Button();
            this.buttonQuantization = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.maskedTextBoxQuantizationLevels = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxSampleFrequency = new System.Windows.Forms.MaskedTextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.buttonSample = new System.Windows.Forms.Button();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1Real
            // 
            this.chart1Real.BackColor = System.Drawing.Color.DarkRed;
            this.chart1Real.BackColorTransparent = true;
            this.chart1Real.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chart1Real.Location = new System.Drawing.Point(12, 15);
            this.chart1Real.Name = "chart1Real";
            this.chart1Real.Size = new System.Drawing.Size(679, 335);
            this.chart1Real.TabIndex = 0;
            this.chart1Real.Text = "cartesianChart1";
            // 
            // chart1Im
            // 
            this.chart1Im.BackColor = System.Drawing.Color.DarkRed;
            this.chart1Im.BackColorTransparent = true;
            this.chart1Im.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chart1Im.Location = new System.Drawing.Point(12, 356);
            this.chart1Im.Name = "chart1Im";
            this.chart1Im.Size = new System.Drawing.Size(679, 342);
            this.chart1Im.TabIndex = 5;
            this.chart1Im.Text = "cartesianChart1";
            // 
            // chart2Real
            // 
            this.chart2Real.BackColor = System.Drawing.Color.ForestGreen;
            this.chart2Real.BackColorTransparent = true;
            this.chart2Real.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chart2Real.Location = new System.Drawing.Point(697, 15);
            this.chart2Real.Name = "chart2Real";
            this.chart2Real.Size = new System.Drawing.Size(375, 185);
            this.chart2Real.TabIndex = 6;
            this.chart2Real.Text = "cartesianChart1";
            // 
            // maskedTextBoxFrequency
            // 
            this.maskedTextBoxFrequency.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.maskedTextBoxFrequency.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.maskedTextBoxFrequency.Location = new System.Drawing.Point(306, 197);
            this.maskedTextBoxFrequency.Mask = "0000000";
            this.maskedTextBoxFrequency.Name = "maskedTextBoxFrequency";
            this.maskedTextBoxFrequency.Size = new System.Drawing.Size(87, 29);
            this.maskedTextBoxFrequency.TabIndex = 10;
            this.maskedTextBoxFrequency.ValidatingType = typeof(int);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(3, 194);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(236, 48);
            this.label9.TabIndex = 7;
            this.label9.Text = "Częstotliwość próbkowania (generacja) [Hz]";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maskedTextBoxProbability
            // 
            this.maskedTextBoxProbability.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.maskedTextBoxProbability.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.maskedTextBoxProbability.Location = new System.Drawing.Point(306, 151);
            this.maskedTextBoxProbability.Name = "maskedTextBoxProbability";
            this.maskedTextBoxProbability.Size = new System.Drawing.Size(87, 29);
            this.maskedTextBoxProbability.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(3, 148);
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
            this.label7.Location = new System.Drawing.Point(3, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 24);
            this.label7.TabIndex = 4;
            this.label7.Text = "Czas skoku (ts) ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maskedTextBoxJumpTime
            // 
            this.maskedTextBoxJumpTime.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.maskedTextBoxJumpTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.maskedTextBoxJumpTime.Location = new System.Drawing.Point(306, 116);
            this.maskedTextBoxJumpTime.Name = "maskedTextBoxJumpTime";
            this.maskedTextBoxJumpTime.Size = new System.Drawing.Size(87, 29);
            this.maskedTextBoxJumpTime.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.94541F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.05459F));
            this.tableLayoutPanel2.Controls.Add(this.label14, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.maskedTextBoxSampleNumber, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label15, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.maskedTextBoxFirstSampleNumber, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.maskedTextBoxFrequency, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.maskedTextBoxProbability, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.maskedTextBoxJumpTime, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label16, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.maskedTextBoxNuberOfSamples, 1, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(1094, 214);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.92958F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.07042F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(410, 249);
            this.tableLayoutPanel2.TabIndex = 11;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.Location = new System.Drawing.Point(3, 43);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(162, 24);
            this.label14.TabIndex = 11;
            this.label14.Text = "Numer próbki (ns)";
            // 
            // maskedTextBoxSampleNumber
            // 
            this.maskedTextBoxSampleNumber.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.maskedTextBoxSampleNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.maskedTextBoxSampleNumber.Location = new System.Drawing.Point(306, 46);
            this.maskedTextBoxSampleNumber.Mask = "000";
            this.maskedTextBoxSampleNumber.Name = "maskedTextBoxSampleNumber";
            this.maskedTextBoxSampleNumber.Size = new System.Drawing.Size(87, 29);
            this.maskedTextBoxSampleNumber.TabIndex = 12;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label15.Location = new System.Drawing.Point(3, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(209, 24);
            this.label15.TabIndex = 13;
            this.label15.Text = "Numer pierwszej próbki";
            // 
            // maskedTextBoxFirstSampleNumber
            // 
            this.maskedTextBoxFirstSampleNumber.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.maskedTextBoxFirstSampleNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.maskedTextBoxFirstSampleNumber.Location = new System.Drawing.Point(306, 3);
            this.maskedTextBoxFirstSampleNumber.Name = "maskedTextBoxFirstSampleNumber";
            this.maskedTextBoxFirstSampleNumber.Size = new System.Drawing.Size(87, 29);
            this.maskedTextBoxFirstSampleNumber.TabIndex = 14;
            this.maskedTextBoxFirstSampleNumber.ValidatingType = typeof(int);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label16.Location = new System.Drawing.Point(3, 79);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(133, 24);
            this.label16.TabIndex = 15;
            this.label16.Text = "Ilość próbek (l)";
            // 
            // maskedTextBoxNuberOfSamples
            // 
            this.maskedTextBoxNuberOfSamples.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.maskedTextBoxNuberOfSamples.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.maskedTextBoxNuberOfSamples.Location = new System.Drawing.Point(306, 82);
            this.maskedTextBoxNuberOfSamples.Mask = "000";
            this.maskedTextBoxNuberOfSamples.Name = "maskedTextBoxNuberOfSamples";
            this.maskedTextBoxNuberOfSamples.Size = new System.Drawing.Size(87, 29);
            this.maskedTextBoxNuberOfSamples.TabIndex = 16;
            // 
            // maskedTextBoxFilling
            // 
            this.maskedTextBoxFilling.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.maskedTextBoxFilling.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.maskedTextBoxFilling.Location = new System.Drawing.Point(307, 156);
            this.maskedTextBoxFilling.Name = "maskedTextBoxFilling";
            this.maskedTextBoxFilling.Size = new System.Drawing.Size(71, 29);
            this.maskedTextBoxFilling.TabIndex = 12;
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
            this.maskedTextBoxStartTime.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.maskedTextBoxStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.maskedTextBoxStartTime.Location = new System.Drawing.Point(307, 39);
            this.maskedTextBoxStartTime.Name = "maskedTextBoxStartTime";
            this.maskedTextBoxStartTime.Size = new System.Drawing.Size(71, 29);
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
            this.maskedTextBoxAmplitude.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.maskedTextBoxAmplitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.maskedTextBoxAmplitude.Location = new System.Drawing.Point(307, 3);
            this.maskedTextBoxAmplitude.Name = "maskedTextBoxAmplitude";
            this.maskedTextBoxAmplitude.Size = new System.Drawing.Size(71, 29);
            this.maskedTextBoxAmplitude.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(3, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(279, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "Współczynnik wypełnienia (kw)";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.39024F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.60976F));
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.maskedTextBoxAmplitude, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.maskedTextBoxStartTime, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.maskedTextBoxDuration, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.maskedTextBoxPeriod, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.maskedTextBoxFilling, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1094, 12);
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
            // maskedTextBoxDuration
            // 
            this.maskedTextBoxDuration.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.maskedTextBoxDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.maskedTextBoxDuration.Location = new System.Drawing.Point(307, 75);
            this.maskedTextBoxDuration.Name = "maskedTextBoxDuration";
            this.maskedTextBoxDuration.Size = new System.Drawing.Size(71, 29);
            this.maskedTextBoxDuration.TabIndex = 10;
            // 
            // maskedTextBoxPeriod
            // 
            this.maskedTextBoxPeriod.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.maskedTextBoxPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.maskedTextBoxPeriod.Location = new System.Drawing.Point(307, 113);
            this.maskedTextBoxPeriod.Name = "maskedTextBoxPeriod";
            this.maskedTextBoxPeriod.Size = new System.Drawing.Size(71, 29);
            this.maskedTextBoxPeriod.TabIndex = 8;
            // 
            // buttonGenerateSignal
            // 
            this.buttonGenerateSignal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonGenerateSignal.Location = new System.Drawing.Point(1095, 566);
            this.buttonGenerateSignal.Name = "buttonGenerateSignal";
            this.buttonGenerateSignal.Size = new System.Drawing.Size(211, 52);
            this.buttonGenerateSignal.TabIndex = 12;
            this.buttonGenerateSignal.Text = "Generuj";
            this.buttonGenerateSignal.UseVisualStyleBackColor = true;
            this.buttonGenerateSignal.Click += new System.EventHandler(this.buttonGenerateSignal_Click);
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
            this.comboBoxSignalType.Location = new System.Drawing.Point(1095, 501);
            this.comboBoxSignalType.Name = "comboBoxSignalType";
            this.comboBoxSignalType.Size = new System.Drawing.Size(409, 28);
            this.comboBoxSignalType.TabIndex = 13;
            this.comboBoxSignalType.Text = "Wybierz typ sygnału";
            this.comboBoxSignalType.SelectedIndexChanged += new System.EventHandler(this.comboBoxSignalType_SelectedIndexChanged);
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSave.Location = new System.Drawing.Point(1312, 566);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(192, 52);
            this.buttonSave.TabIndex = 14;
            this.buttonSave.Text = "Zapisz";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
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
            this.comboBoxNumberOfSections.Location = new System.Drawing.Point(1095, 531);
            this.comboBoxNumberOfSections.Name = "comboBoxNumberOfSections";
            this.comboBoxNumberOfSections.Size = new System.Drawing.Size(409, 28);
            this.comboBoxNumberOfSections.TabIndex = 15;
            this.comboBoxNumberOfSections.Text = "Wybierz liczbę przedziałów histogramu";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.24601F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tableLayoutPanel3.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label10, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label12, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.label13, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.label11, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.TextBoxAverageSignal, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.TextBoxAverageAbsSignal, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.TextBoxAveragePower, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.TextBoxVariance, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.TextBoxEffectiveValue, 1, 4);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(697, 396);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.29578F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.70422F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(377, 173);
            this.tableLayoutPanel3.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(219, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Wartość średnia sygnału";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(3, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(262, 24);
            this.label10.TabIndex = 7;
            this.label10.Text = "Wartość średnia bezwzględna";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(3, 106);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(167, 24);
            this.label12.TabIndex = 11;
            this.label12.Text = "Wariancja sygnału";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(3, 139);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(167, 24);
            this.label13.TabIndex = 13;
            this.label13.Text = "Wartość skuteczna";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(3, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(188, 24);
            this.label11.TabIndex = 9;
            this.label11.Text = "Moc średnia sygnału";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBoxAverageSignal
            // 
            this.TextBoxAverageSignal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBoxAverageSignal.Location = new System.Drawing.Point(271, 3);
            this.TextBoxAverageSignal.Name = "TextBoxAverageSignal";
            this.TextBoxAverageSignal.Size = new System.Drawing.Size(100, 29);
            this.TextBoxAverageSignal.TabIndex = 14;
            // 
            // TextBoxAverageAbsSignal
            // 
            this.TextBoxAverageAbsSignal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBoxAverageAbsSignal.Location = new System.Drawing.Point(271, 38);
            this.TextBoxAverageAbsSignal.Name = "TextBoxAverageAbsSignal";
            this.TextBoxAverageAbsSignal.Size = new System.Drawing.Size(100, 29);
            this.TextBoxAverageAbsSignal.TabIndex = 15;
            // 
            // TextBoxAveragePower
            // 
            this.TextBoxAveragePower.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBoxAveragePower.Location = new System.Drawing.Point(271, 73);
            this.TextBoxAveragePower.Name = "TextBoxAveragePower";
            this.TextBoxAveragePower.Size = new System.Drawing.Size(100, 29);
            this.TextBoxAveragePower.TabIndex = 16;
            // 
            // TextBoxVariance
            // 
            this.TextBoxVariance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBoxVariance.Location = new System.Drawing.Point(271, 109);
            this.TextBoxVariance.Name = "TextBoxVariance";
            this.TextBoxVariance.Size = new System.Drawing.Size(100, 29);
            this.TextBoxVariance.TabIndex = 17;
            // 
            // TextBoxEffectiveValue
            // 
            this.TextBoxEffectiveValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBoxEffectiveValue.Location = new System.Drawing.Point(271, 142);
            this.TextBoxEffectiveValue.Name = "TextBoxEffectiveValue";
            this.TextBoxEffectiveValue.Size = new System.Drawing.Size(100, 29);
            this.TextBoxEffectiveValue.TabIndex = 18;
            // 
            // chart2Im
            // 
            this.chart2Im.BackColor = System.Drawing.Color.ForestGreen;
            this.chart2Im.BackColorTransparent = true;
            this.chart2Im.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chart2Im.Location = new System.Drawing.Point(697, 214);
            this.chart2Im.Name = "chart2Im";
            this.chart2Im.Size = new System.Drawing.Size(375, 185);
            this.chart2Im.TabIndex = 17;
            this.chart2Im.Text = "cartesianChart1";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.AutoSize = true;
            this.tableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.24601F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tableLayoutPanel4.Controls.Add(this.label17, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label18, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label19, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.label21, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.textBoxMeanSquareError, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.textBoxSignalNoiseRatio, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.textBoxHighestSignalNoiseRatio, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.textBoxMaxDifference, 1, 3);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(697, 621);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.29578F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.70422F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(426, 140);
            this.tableLayoutPanel4.TabIndex = 18;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label17.Location = new System.Drawing.Point(3, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(182, 24);
            this.label17.TabIndex = 5;
            this.label17.Text = "Błąd średnio. (MSE)";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label18.Location = new System.Drawing.Point(3, 35);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(296, 24);
            this.label18.TabIndex = 7;
            this.label18.Text = "Stosunek sygnał-szum (SNR) [dB]";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label19.Location = new System.Drawing.Point(3, 106);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(226, 24);
            this.label19.TabIndex = 11;
            this.label19.Text = "Maksymalna różnica (MD)";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label21.Location = new System.Drawing.Point(3, 70);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(311, 24);
            this.label21.TabIndex = 9;
            this.label21.Text = "Szczytowy stosunek s-s (PSNR) [db]";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxMeanSquareError
            // 
            this.textBoxMeanSquareError.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxMeanSquareError.Location = new System.Drawing.Point(320, 3);
            this.textBoxMeanSquareError.Name = "textBoxMeanSquareError";
            this.textBoxMeanSquareError.Size = new System.Drawing.Size(100, 29);
            this.textBoxMeanSquareError.TabIndex = 14;
            // 
            // textBoxSignalNoiseRatio
            // 
            this.textBoxSignalNoiseRatio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxSignalNoiseRatio.Location = new System.Drawing.Point(320, 38);
            this.textBoxSignalNoiseRatio.Name = "textBoxSignalNoiseRatio";
            this.textBoxSignalNoiseRatio.Size = new System.Drawing.Size(100, 29);
            this.textBoxSignalNoiseRatio.TabIndex = 15;
            // 
            // textBoxHighestSignalNoiseRatio
            // 
            this.textBoxHighestSignalNoiseRatio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxHighestSignalNoiseRatio.Location = new System.Drawing.Point(320, 73);
            this.textBoxHighestSignalNoiseRatio.Name = "textBoxHighestSignalNoiseRatio";
            this.textBoxHighestSignalNoiseRatio.Size = new System.Drawing.Size(100, 29);
            this.textBoxHighestSignalNoiseRatio.TabIndex = 16;
            // 
            // textBoxMaxDifference
            // 
            this.textBoxMaxDifference.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxMaxDifference.Location = new System.Drawing.Point(320, 109);
            this.textBoxMaxDifference.Name = "textBoxMaxDifference";
            this.textBoxMaxDifference.Size = new System.Drawing.Size(100, 29);
            this.textBoxMaxDifference.TabIndex = 17;
            // 
            // buttonRecontruction
            // 
            this.buttonRecontruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonRecontruction.Location = new System.Drawing.Point(382, 712);
            this.buttonRecontruction.Name = "buttonRecontruction";
            this.buttonRecontruction.Size = new System.Drawing.Size(192, 52);
            this.buttonRecontruction.TabIndex = 21;
            this.buttonRecontruction.Text = "Rekonstruuj";
            this.buttonRecontruction.UseVisualStyleBackColor = true;
            this.buttonRecontruction.Click += new System.EventHandler(this.buttonRecontruction_Click);
            // 
            // buttonQuantization
            // 
            this.buttonQuantization.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonQuantization.Location = new System.Drawing.Point(240, 712);
            this.buttonQuantization.Name = "buttonQuantization";
            this.buttonQuantization.Size = new System.Drawing.Size(136, 52);
            this.buttonQuantization.TabIndex = 20;
            this.buttonQuantization.Text = "Kwantyzuj";
            this.buttonQuantization.UseVisualStyleBackColor = true;
            this.buttonQuantization.Click += new System.EventHandler(this.buttonQuantization_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label20.Location = new System.Drawing.Point(12, 712);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(181, 24);
            this.label20.TabIndex = 22;
            this.label20.Text = "Poziomy kwantyzacji";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maskedTextBoxQuantizationLevels
            // 
            this.maskedTextBoxQuantizationLevels.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.maskedTextBoxQuantizationLevels.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.maskedTextBoxQuantizationLevels.Location = new System.Drawing.Point(54, 739);
            this.maskedTextBoxQuantizationLevels.Mask = "0000000";
            this.maskedTextBoxQuantizationLevels.Name = "maskedTextBoxQuantizationLevels";
            this.maskedTextBoxQuantizationLevels.Size = new System.Drawing.Size(87, 29);
            this.maskedTextBoxQuantizationLevels.TabIndex = 23;
            this.maskedTextBoxQuantizationLevels.ValidatingType = typeof(int);
            // 
            // maskedTextBoxSampleFrequency
            // 
            this.maskedTextBoxSampleFrequency.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.maskedTextBoxSampleFrequency.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.maskedTextBoxSampleFrequency.Location = new System.Drawing.Point(1385, 669);
            this.maskedTextBoxSampleFrequency.Mask = "0000000";
            this.maskedTextBoxSampleFrequency.Name = "maskedTextBoxSampleFrequency";
            this.maskedTextBoxSampleFrequency.Size = new System.Drawing.Size(87, 29);
            this.maskedTextBoxSampleFrequency.TabIndex = 25;
            this.maskedTextBoxSampleFrequency.ValidatingType = typeof(int);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label22.Location = new System.Drawing.Point(1141, 669);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(236, 24);
            this.label22.TabIndex = 24;
            this.label22.Text = "Częstotliwość próbkowania";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSample
            // 
            this.buttonSample.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSample.Location = new System.Drawing.Point(1147, 707);
            this.buttonSample.Name = "buttonSample";
            this.buttonSample.Size = new System.Drawing.Size(136, 52);
            this.buttonSample.TabIndex = 26;
            this.buttonSample.Text = "Próbkuj";
            this.buttonSample.UseVisualStyleBackColor = true;
            this.buttonSample.Click += new System.EventHandler(this.buttonSample_Click);
            // 
            // Card
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1516, 773);
            this.Controls.Add(this.buttonSample);
            this.Controls.Add(this.maskedTextBoxSampleFrequency);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.maskedTextBoxQuantizationLevels);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.buttonRecontruction);
            this.Controls.Add(this.buttonQuantization);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.chart2Im);
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Card_FormClosing);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private LiveCharts.WinForms.CartesianChart chart2Im;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDuration;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPeriod;
        private System.Windows.Forms.TextBox TextBoxAverageSignal;
        private System.Windows.Forms.TextBox TextBoxAverageAbsSignal;
        private System.Windows.Forms.TextBox TextBoxAveragePower;
        private System.Windows.Forms.TextBox TextBoxVariance;
        private System.Windows.Forms.TextBox TextBoxEffectiveValue;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxSampleNumber;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxFirstSampleNumber;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxNuberOfSamples;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBoxMeanSquareError;
        private System.Windows.Forms.TextBox textBoxSignalNoiseRatio;
        private System.Windows.Forms.TextBox textBoxHighestSignalNoiseRatio;
        private System.Windows.Forms.TextBox textBoxMaxDifference;
        private System.Windows.Forms.Button buttonRecontruction;
        private System.Windows.Forms.Button buttonQuantization;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxQuantizationLevels;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxSampleFrequency;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button buttonSample;
    }
}

