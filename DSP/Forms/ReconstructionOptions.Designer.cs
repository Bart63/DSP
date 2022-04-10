
namespace DSP
{
    partial class ReconstructionOptions
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
            this.maskedTextBoxNumberOfSamplesSinc = new System.Windows.Forms.MaskedTextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.buttonRecontruction = new System.Windows.Forms.Button();
            this.comboBoxReconstructionType = new System.Windows.Forms.ComboBox();
            this.comboBoxSignalToReconstruct = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // maskedTextBoxNumberOfSamplesSinc
            // 
            this.maskedTextBoxNumberOfSamplesSinc.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.maskedTextBoxNumberOfSamplesSinc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.maskedTextBoxNumberOfSamplesSinc.Location = new System.Drawing.Point(286, 192);
            this.maskedTextBoxNumberOfSamplesSinc.Mask = "0000000";
            this.maskedTextBoxNumberOfSamplesSinc.Name = "maskedTextBoxNumberOfSamplesSinc";
            this.maskedTextBoxNumberOfSamplesSinc.Size = new System.Drawing.Size(87, 29);
            this.maskedTextBoxNumberOfSamplesSinc.TabIndex = 33;
            this.maskedTextBoxNumberOfSamplesSinc.ValidatingType = typeof(int);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label23.Location = new System.Drawing.Point(12, 194);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(163, 24);
            this.label23.TabIndex = 32;
            this.label23.Text = "Ilość próbek (sinc)";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonRecontruction
            // 
            this.buttonRecontruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonRecontruction.Location = new System.Drawing.Point(12, 274);
            this.buttonRecontruction.Name = "buttonRecontruction";
            this.buttonRecontruction.Size = new System.Drawing.Size(559, 52);
            this.buttonRecontruction.TabIndex = 29;
            this.buttonRecontruction.Text = "Rekonstruuj";
            this.buttonRecontruction.UseVisualStyleBackColor = true;
            this.buttonRecontruction.Click += new System.EventHandler(this.buttonRecontruction_Click);
            // 
            // comboBoxReconstructionType
            // 
            this.comboBoxReconstructionType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxReconstructionType.FormattingEnabled = true;
            this.comboBoxReconstructionType.Items.AddRange(new object[] {
            "Interpolacja pierwszego rzędu",
            "Rekonstrukcja w oparciu o funkcję sinc"});
            this.comboBoxReconstructionType.Location = new System.Drawing.Point(12, 12);
            this.comboBoxReconstructionType.Name = "comboBoxReconstructionType";
            this.comboBoxReconstructionType.Size = new System.Drawing.Size(265, 28);
            this.comboBoxReconstructionType.TabIndex = 28;
            this.comboBoxReconstructionType.Text = "Wybierz typ rekonstrukcji sygnału";
            // 
            // comboBoxSignalToReconstruct
            // 
            this.comboBoxSignalToReconstruct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxSignalToReconstruct.FormattingEnabled = true;
            this.comboBoxSignalToReconstruct.Location = new System.Drawing.Point(12, 59);
            this.comboBoxSignalToReconstruct.Name = "comboBoxSignalToReconstruct";
            this.comboBoxSignalToReconstruct.Size = new System.Drawing.Size(265, 28);
            this.comboBoxSignalToReconstruct.TabIndex = 34;
            this.comboBoxSignalToReconstruct.Text = "Wybierz sygnał do rekonstrukcji";
            // 
            // ReconstructionOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 338);
            this.Controls.Add(this.comboBoxSignalToReconstruct);
            this.Controls.Add(this.maskedTextBoxNumberOfSamplesSinc);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.buttonRecontruction);
            this.Controls.Add(this.comboBoxReconstructionType);
            this.Name = "ReconstructionOptions";
            this.Text = "Rekonstruuj sygnał";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextBoxNumberOfSamplesSinc;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button buttonRecontruction;
        private System.Windows.Forms.ComboBox comboBoxReconstructionType;
        private System.Windows.Forms.ComboBox comboBoxSignalToReconstruct;
    }
}