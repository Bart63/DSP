
namespace DSP
{
    partial class UseFilter
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
            this.comboBoxFilterType = new System.Windows.Forms.ComboBox();
            this.comboBoxSignal = new System.Windows.Forms.ComboBox();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // comboBoxFilterType
            // 
            this.comboBoxFilterType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxFilterType.FormattingEnabled = true;
            this.comboBoxFilterType.Location = new System.Drawing.Point(13, 51);
            this.comboBoxFilterType.Name = "comboBoxFilterType";
            this.comboBoxFilterType.Size = new System.Drawing.Size(442, 33);
            this.comboBoxFilterType.TabIndex = 6;
            this.comboBoxFilterType.Text = "Wybierz filtr";
            this.comboBoxFilterType.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilterType_SelectedIndexChanged);
            // 
            // comboBoxSignal
            // 
            this.comboBoxSignal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxSignal.FormattingEnabled = true;
            this.comboBoxSignal.Location = new System.Drawing.Point(12, 12);
            this.comboBoxSignal.Name = "comboBoxSignal";
            this.comboBoxSignal.Size = new System.Drawing.Size(442, 33);
            this.comboBoxSignal.TabIndex = 7;
            this.comboBoxSignal.Text = "Wybierz sygnał";
            this.comboBoxSignal.SelectedIndexChanged += new System.EventHandler(this.comboBoxSignal_SelectedIndexChanged);
            // 
            // buttonFilter
            // 
            this.buttonFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonFilter.Location = new System.Drawing.Point(12, 348);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(442, 40);
            this.buttonFilter.TabIndex = 8;
            this.buttonFilter.Text = "Filtruj";
            this.buttonFilter.UseVisualStyleBackColor = true;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBox1.Location = new System.Drawing.Point(13, 91);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(441, 251);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // UseFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 400);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.buttonFilter);
            this.Controls.Add(this.comboBoxFilterType);
            this.Controls.Add(this.comboBoxSignal);
            this.Name = "UseFilter";
            this.Text = "UseFilter";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxFilterType;
        private System.Windows.Forms.ComboBox comboBoxSignal;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}