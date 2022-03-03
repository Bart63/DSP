
namespace DSP
{
    partial class Menu
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
            this.buttonNewCard = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonOperations = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonNewCard
            // 
            this.buttonNewCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonNewCard.Location = new System.Drawing.Point(12, 12);
            this.buttonNewCard.Name = "buttonNewCard";
            this.buttonNewCard.Size = new System.Drawing.Size(393, 118);
            this.buttonNewCard.TabIndex = 13;
            this.buttonNewCard.Text = "Nowa karta";
            this.buttonNewCard.UseVisualStyleBackColor = true;
            this.buttonNewCard.Click += new System.EventHandler(this.buttonNewCard_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonLoad.Location = new System.Drawing.Point(12, 136);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(393, 118);
            this.buttonLoad.TabIndex = 14;
            this.buttonLoad.Text = "Wczytaj";
            this.buttonLoad.UseVisualStyleBackColor = true;
            // 
            // buttonOperations
            // 
            this.buttonOperations.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonOperations.Location = new System.Drawing.Point(12, 260);
            this.buttonOperations.Name = "buttonOperations";
            this.buttonOperations.Size = new System.Drawing.Size(393, 118);
            this.buttonOperations.TabIndex = 15;
            this.buttonOperations.Text = "Wykonaj działanie";
            this.buttonOperations.UseVisualStyleBackColor = true;
            this.buttonOperations.Click += new System.EventHandler(this.buttonOperations_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(417, 391);
            this.Controls.Add(this.buttonOperations);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonNewCard);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonNewCard;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonOperations;
    }
}