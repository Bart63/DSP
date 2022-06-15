
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
            this.buttonRecontruction = new System.Windows.Forms.Button();
            this.buttonQuantization = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.maskedTextBoxQuantizationLevels = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxSampleFrequency = new System.Windows.Forms.MaskedTextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.buttonSample = new System.Windows.Forms.Button();
            this.buttonChartOptions = new System.Windows.Forms.Button();
            this.buttonShowCalculatedParams = new System.Windows.Forms.Button();
            this.buttonShowHistograms = new System.Windows.Forms.Button();
            this.buttonSaveChart = new System.Windows.Forms.Button();
            this.buttonFilterGenerator = new System.Windows.Forms.Button();
            this.buttonSignalFilter = new System.Windows.Forms.Button();
            this.buttonTransformSignal = new System.Windows.Forms.Button();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1Real
            // 
            this.chart1Real.BackColor = System.Drawing.Color.DarkRed;
            this.chart1Real.BackColorTransparent = true;
            this.chart1Real.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chart1Real.Location = new System.Drawing.Point(16, 12);
            this.chart1Real.Name = "chart1Real";
            this.chart1Real.Size = new System.Drawing.Size(1020, 335);
            this.chart1Real.TabIndex = 0;
            this.chart1Real.Text = "cartesianChart1";
            // 
            // chart1Im
            // 
            this.chart1Im.BackColor = System.Drawing.Color.DarkRed;
            this.chart1Im.BackColorTransparent = true;
            this.chart1Im.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chart1Im.Location = new System.Drawing.Point(16, 353);
            this.chart1Im.Name = "chart1Im";
            this.chart1Im.Size = new System.Drawing.Size(1020, 338);
            this.chart1Im.TabIndex = 5;
            this.chart1Im.Text = "cartesianChart1";
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
            this.maskedTextBoxFilling.Location = new System.Drawing.Point(308, 156);
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
            this.maskedTextBoxStartTime.Location = new System.Drawing.Point(308, 39);
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
            this.maskedTextBoxAmplitude.Location = new System.Drawing.Point(308, 3);
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
            this.maskedTextBoxDuration.Location = new System.Drawing.Point(308, 75);
            this.maskedTextBoxDuration.Name = "maskedTextBoxDuration";
            this.maskedTextBoxDuration.Size = new System.Drawing.Size(71, 29);
            this.maskedTextBoxDuration.TabIndex = 10;
            // 
            // maskedTextBoxPeriod
            // 
            this.maskedTextBoxPeriod.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.maskedTextBoxPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.maskedTextBoxPeriod.Location = new System.Drawing.Point(308, 113);
            this.maskedTextBoxPeriod.Name = "maskedTextBoxPeriod";
            this.maskedTextBoxPeriod.Size = new System.Drawing.Size(71, 29);
            this.maskedTextBoxPeriod.TabIndex = 8;
            // 
            // buttonGenerateSignal
            // 
            this.buttonGenerateSignal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonGenerateSignal.Location = new System.Drawing.Point(1095, 504);
            this.buttonGenerateSignal.Name = "buttonGenerateSignal";
            this.buttonGenerateSignal.Size = new System.Drawing.Size(211, 32);
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
            "szum impulsowy",
            "sygnał S3"});
            this.comboBoxSignalType.Location = new System.Drawing.Point(1095, 470);
            this.comboBoxSignalType.Name = "comboBoxSignalType";
            this.comboBoxSignalType.Size = new System.Drawing.Size(409, 28);
            this.comboBoxSignalType.TabIndex = 13;
            this.comboBoxSignalType.Text = "Wybierz typ sygnału";
            this.comboBoxSignalType.SelectedIndexChanged += new System.EventHandler(this.comboBoxSignalType_SelectedIndexChanged);
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSave.Location = new System.Drawing.Point(1312, 504);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(192, 32);
            this.buttonSave.TabIndex = 14;
            this.buttonSave.Text = "Zapisz";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonRecontruction
            // 
            this.buttonRecontruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonRecontruction.Location = new System.Drawing.Point(382, 712);
            this.buttonRecontruction.Name = "buttonRecontruction";
            this.buttonRecontruction.Size = new System.Drawing.Size(143, 52);
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
            this.maskedTextBoxSampleFrequency.Location = new System.Drawing.Point(1275, 724);
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
            this.label22.Location = new System.Drawing.Point(995, 724);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(274, 24);
            this.label22.TabIndex = 24;
            this.label22.Text = "Częstotliwość próbkowania [Hz]\r\n";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSample
            // 
            this.buttonSample.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSample.Location = new System.Drawing.Point(1368, 712);
            this.buttonSample.Name = "buttonSample";
            this.buttonSample.Size = new System.Drawing.Size(136, 52);
            this.buttonSample.TabIndex = 26;
            this.buttonSample.Text = "Próbkuj";
            this.buttonSample.UseVisualStyleBackColor = true;
            this.buttonSample.Click += new System.EventHandler(this.buttonSample_Click);
            // 
            // buttonChartOptions
            // 
            this.buttonChartOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonChartOptions.Location = new System.Drawing.Point(531, 712);
            this.buttonChartOptions.Name = "buttonChartOptions";
            this.buttonChartOptions.Size = new System.Drawing.Size(82, 52);
            this.buttonChartOptions.TabIndex = 27;
            this.buttonChartOptions.Text = "Opcje";
            this.buttonChartOptions.UseVisualStyleBackColor = true;
            this.buttonChartOptions.Click += new System.EventHandler(this.buttonChartOptions_Click);
            // 
            // buttonShowCalculatedParams
            // 
            this.buttonShowCalculatedParams.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonShowCalculatedParams.Location = new System.Drawing.Point(619, 712);
            this.buttonShowCalculatedParams.Name = "buttonShowCalculatedParams";
            this.buttonShowCalculatedParams.Size = new System.Drawing.Size(204, 52);
            this.buttonShowCalculatedParams.TabIndex = 28;
            this.buttonShowCalculatedParams.Text = "Pokaż właściwości";
            this.buttonShowCalculatedParams.UseVisualStyleBackColor = true;
            this.buttonShowCalculatedParams.Click += new System.EventHandler(this.buttonShowCalculatedParams_Click);
            // 
            // buttonShowHistograms
            // 
            this.buttonShowHistograms.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonShowHistograms.Location = new System.Drawing.Point(1312, 553);
            this.buttonShowHistograms.Name = "buttonShowHistograms";
            this.buttonShowHistograms.Size = new System.Drawing.Size(192, 52);
            this.buttonShowHistograms.TabIndex = 29;
            this.buttonShowHistograms.Text = "Pokaż histogramy";
            this.buttonShowHistograms.UseVisualStyleBackColor = true;
            this.buttonShowHistograms.Click += new System.EventHandler(this.buttonShowHistograms_Click);
            // 
            // buttonSaveChart
            // 
            this.buttonSaveChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSaveChart.Location = new System.Drawing.Point(1095, 553);
            this.buttonSaveChart.Name = "buttonSaveChart";
            this.buttonSaveChart.Size = new System.Drawing.Size(211, 52);
            this.buttonSaveChart.TabIndex = 30;
            this.buttonSaveChart.Text = "Zapisz wykres";
            this.buttonSaveChart.UseVisualStyleBackColor = true;
            this.buttonSaveChart.Click += new System.EventHandler(this.buttonSaveChart_Click);
            // 
            // buttonFilterGenerator
            // 
            this.buttonFilterGenerator.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonFilterGenerator.Location = new System.Drawing.Point(1094, 611);
            this.buttonFilterGenerator.Name = "buttonFilterGenerator";
            this.buttonFilterGenerator.Size = new System.Drawing.Size(211, 52);
            this.buttonFilterGenerator.TabIndex = 31;
            this.buttonFilterGenerator.Text = "Generuj filtr";
            this.buttonFilterGenerator.UseVisualStyleBackColor = true;
            this.buttonFilterGenerator.Click += new System.EventHandler(this.buttonFilterGenerator_Click);
            // 
            // buttonSignalFilter
            // 
            this.buttonSignalFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSignalFilter.Location = new System.Drawing.Point(1311, 611);
            this.buttonSignalFilter.Name = "buttonSignalFilter";
            this.buttonSignalFilter.Size = new System.Drawing.Size(193, 52);
            this.buttonSignalFilter.TabIndex = 32;
            this.buttonSignalFilter.Text = "Zastosuj filtr";
            this.buttonSignalFilter.UseVisualStyleBackColor = true;
            this.buttonSignalFilter.Click += new System.EventHandler(this.buttonSignalFilter_Click);
            // 
            // buttonTransformSignal
            // 
            this.buttonTransformSignal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonTransformSignal.Location = new System.Drawing.Point(829, 712);
            this.buttonTransformSignal.Name = "buttonTransformSignal";
            this.buttonTransformSignal.Size = new System.Drawing.Size(160, 52);
            this.buttonTransformSignal.TabIndex = 33;
            this.buttonTransformSignal.Text = "Przekształć";
            this.buttonTransformSignal.UseVisualStyleBackColor = true;
            this.buttonTransformSignal.Click += new System.EventHandler(this.buttonTransformSignal_Click);
            // 
            // Card
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1516, 773);
            this.Controls.Add(this.buttonTransformSignal);
            this.Controls.Add(this.buttonSignalFilter);
            this.Controls.Add(this.buttonFilterGenerator);
            this.Controls.Add(this.buttonSaveChart);
            this.Controls.Add(this.buttonShowHistograms);
            this.Controls.Add(this.buttonShowCalculatedParams);
            this.Controls.Add(this.buttonChartOptions);
            this.Controls.Add(this.buttonSample);
            this.Controls.Add(this.maskedTextBoxSampleFrequency);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.maskedTextBoxQuantizationLevels);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.buttonRecontruction);
            this.Controls.Add(this.buttonQuantization);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.comboBoxSignalType);
            this.Controls.Add(this.buttonGenerateSignal);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.chart1Im);
            this.Controls.Add(this.chart1Real);
            this.Name = "Card";
            this.Text = "Karta 1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Card_FormClosing);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LiveCharts.WinForms.CartesianChart chart1Real;
        private LiveCharts.WinForms.CartesianChart chart1Im;
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
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDuration;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPeriod;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxSampleNumber;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxFirstSampleNumber;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxNuberOfSamples;
        private System.Windows.Forms.Button buttonRecontruction;
        private System.Windows.Forms.Button buttonQuantization;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxQuantizationLevels;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxSampleFrequency;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button buttonSample;
        private System.Windows.Forms.Button buttonChartOptions;
        private System.Windows.Forms.Button buttonShowCalculatedParams;
        private System.Windows.Forms.Button buttonShowHistograms;
        private System.Windows.Forms.Button buttonSaveChart;
        private System.Windows.Forms.Button buttonFilterGenerator;
        private System.Windows.Forms.Button buttonSignalFilter;
        private System.Windows.Forms.Button buttonTransformSignal;
    }
}

