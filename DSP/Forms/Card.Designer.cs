
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
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.maskedTextBoxAverageSignal = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.maskedTextBoxAverageAbsSignal = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxAveragePower = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.maskedTextBoxWariation = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.maskedTextBoxEffectiveValue = new System.Windows.Forms.MaskedTextBox();
            this.chart2Im = new LiveCharts.WinForms.CartesianChart();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1Real
            // 
            this.chart1Real.BackColor = System.Drawing.Color.DarkRed;
            this.chart1Real.BackColorTransparent = true;
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
            this.chart1Im.BackColorTransparent = true;
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
            this.chart2Real.BackColorTransparent = true;
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
            this.maskedTextBoxFrequency.Mask = "00000";
            this.maskedTextBoxFrequency.Name = "maskedTextBoxFrequency";
            this.maskedTextBoxFrequency.Size = new System.Drawing.Size(53, 29);
            this.maskedTextBoxFrequency.TabIndex = 10;
            this.maskedTextBoxFrequency.ValidatingType = typeof(int);
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
            this.maskedTextBoxFilling.Location = new System.Drawing.Point(307, 156);
            this.maskedTextBoxFilling.Mask = "00.00";
            this.maskedTextBoxFilling.Name = "maskedTextBoxFilling";
            this.maskedTextBoxFilling.Size = new System.Drawing.Size(53, 29);
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
            this.maskedTextBoxStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.maskedTextBoxStartTime.Location = new System.Drawing.Point(307, 39);
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
            this.maskedTextBoxAmplitude.Location = new System.Drawing.Point(307, 3);
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
            // maskedTextBoxDuration
            // 
            this.maskedTextBoxDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.maskedTextBoxDuration.Location = new System.Drawing.Point(307, 75);
            this.maskedTextBoxDuration.Mask = "00.00";
            this.maskedTextBoxDuration.Name = "maskedTextBoxDuration";
            this.maskedTextBoxDuration.Size = new System.Drawing.Size(53, 29);
            this.maskedTextBoxDuration.TabIndex = 10;
            // 
            // maskedTextBoxPeriod
            // 
            this.maskedTextBoxPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.maskedTextBoxPeriod.Location = new System.Drawing.Point(307, 113);
            this.maskedTextBoxPeriod.Mask = "00.00";
            this.maskedTextBoxPeriod.Name = "maskedTextBoxPeriod";
            this.maskedTextBoxPeriod.Size = new System.Drawing.Size(53, 29);
            this.maskedTextBoxPeriod.TabIndex = 8;
            // 
            // buttonGenerateSignal
            // 
            this.buttonGenerateSignal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonGenerateSignal.Location = new System.Drawing.Point(853, 390);
            this.buttonGenerateSignal.Name = "buttonGenerateSignal";
            this.buttonGenerateSignal.Size = new System.Drawing.Size(336, 57);
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
            this.comboBoxSignalType.Location = new System.Drawing.Point(429, 554);
            this.comboBoxSignalType.Name = "comboBoxSignalType";
            this.comboBoxSignalType.Size = new System.Drawing.Size(409, 28);
            this.comboBoxSignalType.TabIndex = 13;
            this.comboBoxSignalType.Text = "Wybierz typ sygnału";
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSave.Location = new System.Drawing.Point(853, 453);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(336, 57);
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
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.71014F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.28986F));
            this.tableLayoutPanel3.Controls.Add(this.label11, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.maskedTextBoxAverageSignal, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label10, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.maskedTextBoxAverageAbsSignal, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.maskedTextBoxAveragePower, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.label12, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.maskedTextBoxWariation, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.label13, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.maskedTextBoxEffectiveValue, 1, 4);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(853, 522);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.14815F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.85185F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(291, 189);
            this.tableLayoutPanel3.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(3, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(188, 24);
            this.label11.TabIndex = 9;
            this.label11.Text = "Moc średnia sygnału";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // maskedTextBoxAverageSignal
            // 
            this.maskedTextBoxAverageSignal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.maskedTextBoxAverageSignal.Location = new System.Drawing.Point(234, 3);
            this.maskedTextBoxAverageSignal.Mask = "00.00";
            this.maskedTextBoxAverageSignal.Name = "maskedTextBoxAverageSignal";
            this.maskedTextBoxAverageSignal.ReadOnly = true;
            this.maskedTextBoxAverageSignal.Size = new System.Drawing.Size(53, 29);
            this.maskedTextBoxAverageSignal.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(3, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(207, 18);
            this.label10.TabIndex = 7;
            this.label10.Text = "Wartość średnia bezwzględna";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maskedTextBoxAverageAbsSignal
            // 
            this.maskedTextBoxAverageAbsSignal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.maskedTextBoxAverageAbsSignal.Location = new System.Drawing.Point(234, 38);
            this.maskedTextBoxAverageAbsSignal.Mask = "00.00";
            this.maskedTextBoxAverageAbsSignal.Name = "maskedTextBoxAverageAbsSignal";
            this.maskedTextBoxAverageAbsSignal.ReadOnly = true;
            this.maskedTextBoxAverageAbsSignal.Size = new System.Drawing.Size(42, 29);
            this.maskedTextBoxAverageAbsSignal.TabIndex = 8;
            // 
            // maskedTextBoxAveragePower
            // 
            this.maskedTextBoxAveragePower.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.maskedTextBoxAveragePower.Location = new System.Drawing.Point(234, 75);
            this.maskedTextBoxAveragePower.Mask = "00.00";
            this.maskedTextBoxAveragePower.Name = "maskedTextBoxAveragePower";
            this.maskedTextBoxAveragePower.ReadOnly = true;
            this.maskedTextBoxAveragePower.Size = new System.Drawing.Size(42, 29);
            this.maskedTextBoxAveragePower.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(3, 113);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(167, 24);
            this.label12.TabIndex = 11;
            this.label12.Text = "Wariancja sygnału";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maskedTextBoxWariation
            // 
            this.maskedTextBoxWariation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.maskedTextBoxWariation.Location = new System.Drawing.Point(234, 116);
            this.maskedTextBoxWariation.Mask = "00.00";
            this.maskedTextBoxWariation.Name = "maskedTextBoxWariation";
            this.maskedTextBoxWariation.ReadOnly = true;
            this.maskedTextBoxWariation.Size = new System.Drawing.Size(42, 29);
            this.maskedTextBoxWariation.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(3, 145);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(167, 24);
            this.label13.TabIndex = 13;
            this.label13.Text = "Wartość skuteczna";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maskedTextBoxEffectiveValue
            // 
            this.maskedTextBoxEffectiveValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.maskedTextBoxEffectiveValue.Location = new System.Drawing.Point(234, 148);
            this.maskedTextBoxEffectiveValue.Mask = "00.00";
            this.maskedTextBoxEffectiveValue.Name = "maskedTextBoxEffectiveValue";
            this.maskedTextBoxEffectiveValue.ReadOnly = true;
            this.maskedTextBoxEffectiveValue.Size = new System.Drawing.Size(42, 29);
            this.maskedTextBoxEffectiveValue.TabIndex = 14;
            // 
            // chart2Im
            // 
            this.chart2Im.BackColor = System.Drawing.Color.ForestGreen;
            this.chart2Im.BackColorTransparent = true;
            this.chart2Im.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chart2Im.Location = new System.Drawing.Point(429, 264);
            this.chart2Im.Name = "chart2Im";
            this.chart2Im.Size = new System.Drawing.Size(410, 246);
            this.chart2Im.TabIndex = 17;
            this.chart2Im.Text = "cartesianChart1";
            // 
            // Card
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1201, 726);
            this.Controls.Add(this.chart2Im);
            this.Controls.Add(this.tableLayoutPanel3);
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
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
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
        private System.Windows.Forms.MaskedTextBox maskedTextBoxAverageSignal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxAverageAbsSignal;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxAveragePower;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxWariation;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxEffectiveValue;
        private LiveCharts.WinForms.CartesianChart chart2Im;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDuration;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPeriod;
    }
}

