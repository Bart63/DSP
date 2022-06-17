namespace DSP
{
    partial class Transformation
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
            this.comboBoxTransformationType = new System.Windows.Forms.ComboBox();
            this.richTextBoxTransformationInfo = new System.Windows.Forms.RichTextBox();
            this.comboBoxSignal = new System.Windows.Forms.ComboBox();
            this.buttonTransform = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxTransformationType
            // 
            this.comboBoxTransformationType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxTransformationType.FormattingEnabled = true;
            this.comboBoxTransformationType.Items.AddRange(new object[] {
            "DFT",
            "DIT FFT",
            "DCT II",
            "FCT II",
            "I DFT",
            "I DIT FFT",
            "I DCT II",
            "I FCT II"});
            this.comboBoxTransformationType.Location = new System.Drawing.Point(12, 12);
            this.comboBoxTransformationType.Name = "comboBoxTransformationType";
            this.comboBoxTransformationType.Size = new System.Drawing.Size(392, 32);
            this.comboBoxTransformationType.TabIndex = 0;
            this.comboBoxTransformationType.Text = "Wybierz typ przekształcenia";
            this.comboBoxTransformationType.SelectedIndexChanged += new System.EventHandler(this.comboBoxTransformationType_SelectedIndexChanged);
            // 
            // richTextBoxTransformationInfo
            // 
            this.richTextBoxTransformationInfo.Location = new System.Drawing.Point(12, 88);
            this.richTextBoxTransformationInfo.Name = "richTextBoxTransformationInfo";
            this.richTextBoxTransformationInfo.Size = new System.Drawing.Size(392, 147);
            this.richTextBoxTransformationInfo.TabIndex = 1;
            this.richTextBoxTransformationInfo.Text = "";
            // 
            // comboBoxSignal
            // 
            this.comboBoxSignal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxSignal.FormattingEnabled = true;
            this.comboBoxSignal.Location = new System.Drawing.Point(12, 50);
            this.comboBoxSignal.Name = "comboBoxSignal";
            this.comboBoxSignal.Size = new System.Drawing.Size(392, 32);
            this.comboBoxSignal.TabIndex = 2;
            this.comboBoxSignal.Text = "Wybierz sygnał";
            this.comboBoxSignal.SelectedIndexChanged += new System.EventHandler(this.comboBoxSignal_SelectedIndexChanged);
            // 
            // buttonTransform
            // 
            this.buttonTransform.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonTransform.Location = new System.Drawing.Point(12, 241);
            this.buttonTransform.Name = "buttonTransform";
            this.buttonTransform.Size = new System.Drawing.Size(392, 58);
            this.buttonTransform.TabIndex = 3;
            this.buttonTransform.Text = "Przekształć";
            this.buttonTransform.UseVisualStyleBackColor = true;
            this.buttonTransform.Click += new System.EventHandler(this.buttonTransform_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonStop.Location = new System.Drawing.Point(12, 305);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(392, 58);
            this.buttonStop.TabIndex = 4;
            this.buttonStop.Text = "Zatrzymaj";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // Transformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 375);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonTransform);
            this.Controls.Add(this.comboBoxSignal);
            this.Controls.Add(this.richTextBoxTransformationInfo);
            this.Controls.Add(this.comboBoxTransformationType);
            this.Name = "Transformation";
            this.Text = "Transformacje";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxTransformationType;
        private System.Windows.Forms.RichTextBox richTextBoxTransformationInfo;
        private System.Windows.Forms.ComboBox comboBoxSignal;
        private System.Windows.Forms.Button buttonTransform;
        private System.Windows.Forms.Button buttonStop;
    }
}