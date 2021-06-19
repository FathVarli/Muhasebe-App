
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
            this.components = new System.ComponentModel.Container();
            this.lblSaat = new System.Windows.Forms.Label();
            this.btnGelir = new System.Windows.Forms.Button();
            this.btnGider = new System.Windows.Forms.Button();
            this.btnMalzeme = new System.Windows.Forms.Button();
            this.btnRaporlama = new System.Windows.Forms.Button();
            this.lblTarih = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblSaat
            // 
            this.lblSaat.AutoSize = true;
            this.lblSaat.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSaat.Location = new System.Drawing.Point(689, 44);
            this.lblSaat.Name = "lblSaat";
            this.lblSaat.Size = new System.Drawing.Size(34, 17);
            this.lblSaat.TabIndex = 0;
            this.lblSaat.Text = "Saat";
            // 
            // btnGelir
            // 
            this.btnGelir.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGelir.Location = new System.Drawing.Point(118, 174);
            this.btnGelir.Name = "btnGelir";
            this.btnGelir.Size = new System.Drawing.Size(100, 60);
            this.btnGelir.TabIndex = 1;
            this.btnGelir.Text = "Gelir Sayfasi";
            this.btnGelir.UseVisualStyleBackColor = true;
            this.btnGelir.Click += new System.EventHandler(this.btnGelir_Click);
            // 
            // btnGider
            // 
            this.btnGider.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGider.Location = new System.Drawing.Point(264, 174);
            this.btnGider.Name = "btnGider";
            this.btnGider.Size = new System.Drawing.Size(100, 60);
            this.btnGider.TabIndex = 2;
            this.btnGider.Text = "Gider Sayfasi";
            this.btnGider.UseVisualStyleBackColor = true;
            this.btnGider.Click += new System.EventHandler(this.btnGider_Click);
            // 
            // btnMalzeme
            // 
            this.btnMalzeme.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMalzeme.Location = new System.Drawing.Point(410, 174);
            this.btnMalzeme.Name = "btnMalzeme";
            this.btnMalzeme.Size = new System.Drawing.Size(100, 60);
            this.btnMalzeme.TabIndex = 3;
            this.btnMalzeme.Text = "Malzeme Sayfasi";
            this.btnMalzeme.UseVisualStyleBackColor = true;
            this.btnMalzeme.Click += new System.EventHandler(this.btnMalzeme_Click);
            // 
            // btnRaporlama
            // 
            this.btnRaporlama.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRaporlama.Location = new System.Drawing.Point(556, 174);
            this.btnRaporlama.Name = "btnRaporlama";
            this.btnRaporlama.Size = new System.Drawing.Size(100, 60);
            this.btnRaporlama.TabIndex = 4;
            this.btnRaporlama.Text = "Raporlama Sayfasi";
            this.btnRaporlama.UseVisualStyleBackColor = true;
            this.btnRaporlama.Click += new System.EventHandler(this.btnRaporlama_Click);
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarih.Location = new System.Drawing.Point(638, 18);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(38, 17);
            this.lblTarih.TabIndex = 5;
            this.lblTarih.Text = "Tarih";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.btnRaporlama);
            this.Controls.Add(this.btnMalzeme);
            this.Controls.Add(this.btnGider);
            this.Controls.Add(this.btnGelir);
            this.Controls.Add(this.lblSaat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Timer timer1;
    }
}