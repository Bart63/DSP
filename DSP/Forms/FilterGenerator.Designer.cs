
namespace DSP
{
    partial class FilterGenerator
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
            this.buttonAccept = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.comboBoxWindowType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBoxFilterType
            // 
            this.comboBoxFilterType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxFilterType.FormattingEnabled = true;
            this.comboBoxFilterType.Items.AddRange(new object[] {
            "Filtr dolnoprzepustowy",
            "Filtr środkowoprzepustowy"});
            this.comboBoxFilterType.Location = new System.Drawing.Point(12, 12);
            this.comboBoxFilterType.Name = "comboBoxFilterType";
            this.comboBoxFilterType.Size = new System.Drawing.Size(442, 33);
            this.comboBoxFilterType.TabIndex = 0;
            this.comboBoxFilterType.Text = "Wybierz rodzaj filtru";
            this.comboBoxFilterType.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilterType_SelectedIndexChanged);
            // 
            // buttonAccept
            // 
            this.buttonAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAccept.Location = new System.Drawing.Point(12, 466);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(442, 40);
            this.buttonAccept.TabIndex = 1;
            this.buttonAccept.Text = "Zastosuj";
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // panel
            // 
            this.panel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panel.Location = new System.Drawing.Point(13, 90);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(441, 246);
            this.panel.TabIndex = 2;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonCalculate.Location = new System.Drawing.Point(12, 420);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(442, 40);
            this.buttonCalculate.TabIndex = 3;
            this.buttonCalculate.Text = "Generuj";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(13, 342);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(441, 72);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // comboBoxWindowType
            // 
            this.comboBoxWindowType.AutoCompleteCustomSource.AddRange(new string[] {
            "Okno prostokątne",
            "Okno Blackmana"});
            this.comboBoxWindowType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxWindowType.FormattingEnabled = true;
            this.comboBoxWindowType.Items.AddRange(new object[] {
            "Okno prostokątne",
            "Okno Blackmana"});
            this.comboBoxWindowType.Location = new System.Drawing.Point(13, 51);
            this.comboBoxWindowType.Name = "comboBoxWindowType";
            this.comboBoxWindowType.Size = new System.Drawing.Size(442, 33);
            this.comboBoxWindowType.TabIndex = 5;
            this.comboBoxWindowType.Text = "Wybierz rodzaj okna";
            // 
            // FilterGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 518);
            this.Controls.Add(this.comboBoxWindowType);
            this.Controls.Add(this.comboBoxFilterType);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.buttonAccept);
            this.Name = "FilterGenerator";
            this.Text = "Generuj filtr";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxFilterType;
        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.FlowLayoutPanel panel;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox comboBoxWindowType;
    }
}