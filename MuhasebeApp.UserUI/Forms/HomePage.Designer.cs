
namespace MuhasebeApp.UserUI.Forms
{
    partial class HomePage
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
            this.lblSaat = new System.Windows.Forms.Label();
            this.btnGelir = new System.Windows.Forms.Button();
            this.btnGider = new System.Windows.Forms.Button();
            this.btnMalzeme = new System.Windows.Forms.Button();
            this.btnRaporlama = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSaat
            // 
            this.lblSaat.AutoSize = true;
            this.lblSaat.Location = new System.Drawing.Point(709, 48);
            this.lblSaat.Name = "lblSaat";
            this.lblSaat.Size = new System.Drawing.Size(29, 13);
            this.lblSaat.TabIndex = 0;
            this.lblSaat.Text = "Saat";
            // 
            // btnGelir
            // 
            this.btnGelir.Location = new System.Drawing.Point(76, 180);
            this.btnGelir.Name = "btnGelir";
            this.btnGelir.Size = new System.Drawing.Size(75, 23);
            this.btnGelir.TabIndex = 1;
            this.btnGelir.Text = "Gelir Sayfasi";
            this.btnGelir.UseVisualStyleBackColor = true;
            // 
            // btnGider
            // 
            this.btnGider.Location = new System.Drawing.Point(208, 180);
            this.btnGider.Name = "btnGider";
            this.btnGider.Size = new System.Drawing.Size(110, 23);
            this.btnGider.TabIndex = 2;
            this.btnGider.Text = "Gider Sayfasi";
            this.btnGider.UseVisualStyleBackColor = true;
            // 
            // btnMalzeme
            // 
            this.btnMalzeme.Location = new System.Drawing.Point(355, 180);
            this.btnMalzeme.Name = "btnMalzeme";
            this.btnMalzeme.Size = new System.Drawing.Size(110, 23);
            this.btnMalzeme.TabIndex = 3;
            this.btnMalzeme.Text = "Malzeme Sayfasi";
            this.btnMalzeme.UseVisualStyleBackColor = true;
            // 
            // btnRaporlama
            // 
            this.btnRaporlama.Location = new System.Drawing.Point(524, 180);
            this.btnRaporlama.Name = "btnRaporlama";
            this.btnRaporlama.Size = new System.Drawing.Size(110, 23);
            this.btnRaporlama.TabIndex = 4;
            this.btnRaporlama.Text = "Raporlama Sayfasi";
            this.btnRaporlama.UseVisualStyleBackColor = true;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRaporlama);
            this.Controls.Add(this.btnMalzeme);
            this.Controls.Add(this.btnGider);
            this.Controls.Add(this.btnGelir);
            this.Controls.Add(this.lblSaat);
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSaat;
        private System.Windows.Forms.Button btnGelir;
        private System.Windows.Forms.Button btnGider;
        private System.Windows.Forms.Button btnMalzeme;
        private System.Windows.Forms.Button btnRaporlama;
    }
}