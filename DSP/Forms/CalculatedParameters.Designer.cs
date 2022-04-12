
namespace DSP
{
    partial class CalculatedParameters
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
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.textBoxMeanSquareError = new System.Windows.Forms.TextBox();
            this.textBoxSignalNoiseRatio = new System.Windows.Forms.TextBox();
            this.textBoxHighestSignalNoiseRatio = new System.Windows.Forms.TextBox();
            this.textBoxMaxDifference = new System.Windows.Forms.TextBox();
            this.comboBoxSignalType = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.NavajoWhite;
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
            this.tableLayoutPanel3.Location = new System.Drawing.Point(12, 103);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.29578F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.70422F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(377, 173);
            this.tableLayoutPanel3.TabIndex = 17;
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
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.AutoSize = true;
            this.tableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.Tan;
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
            this.tableLayoutPanel4.Location = new System.Drawing.Point(12, 291);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.29578F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.70422F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(426, 140);
            this.tableLayoutPanel4.TabIndex = 19;
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
            // comboBoxSignalType
            // 
            this.comboBoxSignalType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxSignalType.FormattingEnabled = true;
            this.comboBoxSignalType.Location = new System.Drawing.Point(13, 13);
            this.comboBoxSignalType.Name = "comboBoxSignalType";
            this.comboBoxSignalType.Size = new System.Drawing.Size(376, 32);
            this.comboBoxSignalType.TabIndex = 20;
            this.comboBoxSignalType.Text = "Wybierz sygnał";
            this.comboBoxSignalType.SelectedIndexChanged += new System.EventHandler(this.comboBoxSignalType_SelectedIndexChanged);
            // 
            // CalculatedParameters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 450);
            this.Controls.Add(this.comboBoxSignalType);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Name = "CalculatedParameters";
            this.Text = "Właściwości sygnału";
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TextBoxAverageSignal;
        private System.Windows.Forms.TextBox TextBoxAverageAbsSignal;
        private System.Windows.Forms.TextBox TextBoxAveragePower;
        private System.Windows.Forms.TextBox TextBoxVariance;
        private System.Windows.Forms.TextBox TextBoxEffectiveValue;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBoxMeanSquareError;
        private System.Windows.Forms.TextBox textBoxSignalNoiseRatio;
        private System.Windows.Forms.TextBox textBoxHighestSignalNoiseRatio;
        private System.Windows.Forms.TextBox textBoxMaxDifference;
        private System.Windows.Forms.ComboBox comboBoxSignalType;
    }
}