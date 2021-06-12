
namespace MuhasebeApp.UserUI.Forms
{
    partial class GiderEkleme
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
            this.gbxGiderEkleme = new System.Windows.Forms.GroupBox();
            this.lblIcerik = new System.Windows.Forms.Label();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.gbxGiderEkleme.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxGiderEkleme
            // 
            this.gbxGiderEkleme.Controls.Add(this.btnKaydet);
            this.gbxGiderEkleme.Controls.Add(this.textBox3);
            this.gbxGiderEkleme.Controls.Add(this.dateTimePicker1);
            this.gbxGiderEkleme.Controls.Add(this.textBox2);
            this.gbxGiderEkleme.Controls.Add(this.textBox1);
            this.gbxGiderEkleme.Controls.Add(this.lblAciklama);
            this.gbxGiderEkleme.Controls.Add(this.lblTarih);
            this.gbxGiderEkleme.Controls.Add(this.lblToplamTutar);
            this.gbxGiderEkleme.Controls.Add(this.lblIcerik);
            this.gbxGiderEkleme.Location = new System.Drawing.Point(171, 57);
            this.gbxGiderEkleme.Name = "gbxGiderEkleme";
            this.gbxGiderEkleme.Size = new System.Drawing.Size(379, 407);
            this.gbxGiderEkleme.TabIndex = 0;
            this.gbxGiderEkleme.TabStop = false;
            this.gbxGiderEkleme.Text = "Gider Ekleme";
            // 
            // lblIcerik
            // 
            this.lblIcerik.AutoSize = true;
            this.lblIcerik.Location = new System.Drawing.Point(39, 97);
            this.lblIcerik.Name = "lblIcerik";
            this.lblIcerik.Size = new System.Drawing.Size(33, 13);
            this.lblIcerik.TabIndex = 0;
            this.lblIcerik.Text = "İçerik";
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.Location = new System.Drawing.Point(39, 137);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(70, 13);
            this.lblToplamTutar.TabIndex = 1;
            this.lblToplamTutar.Text = "Toplam Tutar";
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Location = new System.Drawing.Point(39, 172);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(31, 13);
            this.lblTarih.TabIndex = 2;
            this.lblTarih.Text = "Tarih";
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Location = new System.Drawing.Point(39, 214);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(50, 13);
            this.lblAciklama.TabIndex = 3;
            this.lblAciklama.Text = "Açıklama";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(135, 97);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(135, 134);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(135, 172);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(135, 211);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(200, 74);
            this.textBox3.TabIndex = 7;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(260, 325);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 8;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 545);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Geri Dön";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // GiderEkleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 580);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.gbxGiderEkleme);
            this.Name = "GiderEkleme";
            this.Text = "GiderEkleme";
            this.gbxGiderEkleme.ResumeLayout(false);
            this.gbxGiderEkleme.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxGiderEkleme;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label lblToplamTutar;
        private System.Windows.Forms.Label lblIcerik;
        private System.Windows.Forms.Button btnBack;
    }
}