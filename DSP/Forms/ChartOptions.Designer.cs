
namespace DSP
{
    partial class ChartOptions
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
            this.button = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // button
            // 
            this.button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button.Location = new System.Drawing.Point(12, 204);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(319, 35);
            this.button.TabIndex = 1;
            this.button.Text = "Zastosuj";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 13);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(319, 185);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // ChartOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 249);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.button);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChartOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Widoczne wykresy";
            this.Load += new System.EventHandler(this.ChartOptions_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}