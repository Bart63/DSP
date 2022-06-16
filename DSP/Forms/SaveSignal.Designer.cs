namespace DSP
{
    partial class SaveSignal
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
            this.comboBoxSignal = new System.Windows.Forms.ComboBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxSignal
            // 
            this.comboBoxSignal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxSignal.FormattingEnabled = true;
            this.comboBoxSignal.Location = new System.Drawing.Point(12, 12);
            this.comboBoxSignal.Name = "comboBoxSignal";
            this.comboBoxSignal.Size = new System.Drawing.Size(713, 33);
            this.comboBoxSignal.TabIndex = 0;
            this.comboBoxSignal.Text = "Wybierz sygnał ";
            this.comboBoxSignal.SelectedIndexChanged += new System.EventHandler(this.comboBoxSignal_SelectedIndexChanged);
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSave.Location = new System.Drawing.Point(12, 51);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(713, 57);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Zapisz";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // SaveSignal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 113);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.comboBoxSignal);
            this.Name = "SaveSignal";
            this.Text = "Zapisz sygnał";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSignal;
        private System.Windows.Forms.Button buttonSave;
    }
}