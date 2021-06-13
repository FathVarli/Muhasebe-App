
namespace MuhasebeApp.UserUI.Forms
{
    partial class GiderListeleme
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
            this.dgvGiderListeleme = new System.Windows.Forms.DataGridView();
            this.gbxGiderEkleme = new System.Windows.Forms.GroupBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.lblIcerik = new System.Windows.Forms.Label();
            this.gbxFiltreleme = new System.Windows.Forms.GroupBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.lblFIcerik = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lblFTarihAralik = new System.Windows.Forms.Label();
            this.lblFBaslangicTarihi = new System.Windows.Forms.Label();
            this.lblBitişTarihi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiderListeleme)).BeginInit();
            this.gbxGiderEkleme.SuspendLayout();
            this.gbxFiltreleme.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvGiderListeleme
            // 
            this.dgvGiderListeleme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGiderListeleme.Location = new System.Drawing.Point(33, 21);
            this.dgvGiderListeleme.Name = "dgvGiderListeleme";
            this.dgvGiderListeleme.Size = new System.Drawing.Size(959, 253);
            this.dgvGiderListeleme.TabIndex = 0;
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
            this.gbxGiderEkleme.Location = new System.Drawing.Point(613, 280);
            this.gbxGiderEkleme.Name = "gbxGiderEkleme";
            this.gbxGiderEkleme.Size = new System.Drawing.Size(379, 296);
            this.gbxGiderEkleme.TabIndex = 1;
            this.gbxGiderEkleme.TabStop = false;
            this.gbxGiderEkleme.Text = "Gider Ekleme";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(257, 244);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 8;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(132, 148);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(200, 74);
            this.textBox3.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(132, 109);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(132, 71);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(132, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Location = new System.Drawing.Point(36, 151);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(50, 13);
            this.lblAciklama.TabIndex = 3;
            this.lblAciklama.Text = "Açıklama";
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Location = new System.Drawing.Point(36, 109);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(31, 13);
            this.lblTarih.TabIndex = 2;
            this.lblTarih.Text = "Tarih";
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.Location = new System.Drawing.Point(36, 74);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(70, 13);
            this.lblToplamTutar.TabIndex = 1;
            this.lblToplamTutar.Text = "Toplam Tutar";
            // 
            // lblIcerik
            // 
            this.lblIcerik.AutoSize = true;
            this.lblIcerik.Location = new System.Drawing.Point(36, 34);
            this.lblIcerik.Name = "lblIcerik";
            this.lblIcerik.Size = new System.Drawing.Size(33, 13);
            this.lblIcerik.TabIndex = 0;
            this.lblIcerik.Text = "İçerik";
            // 
            // gbxFiltreleme
            // 
            this.gbxFiltreleme.Controls.Add(this.btnAra);
            this.gbxFiltreleme.Controls.Add(this.dateTimePicker3);
            this.gbxFiltreleme.Controls.Add(this.lblFIcerik);
            this.gbxFiltreleme.Controls.Add(this.dateTimePicker2);
            this.gbxFiltreleme.Controls.Add(this.textBox4);
            this.gbxFiltreleme.Controls.Add(this.lblFTarihAralik);
            this.gbxFiltreleme.Controls.Add(this.lblFBaslangicTarihi);
            this.gbxFiltreleme.Controls.Add(this.lblBitişTarihi);
            this.gbxFiltreleme.Location = new System.Drawing.Point(33, 280);
            this.gbxFiltreleme.Name = "gbxFiltreleme";
            this.gbxFiltreleme.Size = new System.Drawing.Size(337, 296);
            this.gbxFiltreleme.TabIndex = 2;
            this.gbxFiltreleme.TabStop = false;
            this.gbxFiltreleme.Text = "Filtreleme";
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(231, 244);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(75, 23);
            this.btnAra.TabIndex = 51;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(114, 118);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(181, 20);
            this.dateTimePicker3.TabIndex = 47;
            // 
            // lblFIcerik
            // 
            this.lblFIcerik.AutoSize = true;
            this.lblFIcerik.Location = new System.Drawing.Point(26, 41);
            this.lblFIcerik.Name = "lblFIcerik";
            this.lblFIcerik.Size = new System.Drawing.Size(90, 13);
            this.lblFIcerik.TabIndex = 0;
            this.lblFIcerik.Text = "İçeriğe Göre Ara: ";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(114, 151);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(181, 20);
            this.dateTimePicker2.TabIndex = 48;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(84, 64);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(130, 20);
            this.textBox4.TabIndex = 1;
            // 
            // lblFTarihAralik
            // 
            this.lblFTarihAralik.AutoSize = true;
            this.lblFTarihAralik.Location = new System.Drawing.Point(26, 95);
            this.lblFTarihAralik.Name = "lblFTarihAralik";
            this.lblFTarihAralik.Size = new System.Drawing.Size(122, 13);
            this.lblFTarihAralik.TabIndex = 2;
            this.lblFTarihAralik.Text = "Tarih Aralığına Göre Ara:";
            // 
            // lblFBaslangicTarihi
            // 
            this.lblFBaslangicTarihi.AutoSize = true;
            this.lblFBaslangicTarihi.Location = new System.Drawing.Point(26, 121);
            this.lblFBaslangicTarihi.Name = "lblFBaslangicTarihi";
            this.lblFBaslangicTarihi.Size = new System.Drawing.Size(82, 13);
            this.lblFBaslangicTarihi.TabIndex = 4;
            this.lblFBaslangicTarihi.Text = "Baslangıç Tarihi";
            // 
            // lblBitişTarihi
            // 
            this.lblBitişTarihi.AutoSize = true;
            this.lblBitişTarihi.Location = new System.Drawing.Point(26, 151);
            this.lblBitişTarihi.Name = "lblBitişTarihi";
            this.lblBitişTarihi.Size = new System.Drawing.Size(55, 13);
            this.lblBitişTarihi.TabIndex = 5;
            this.lblBitişTarihi.Text = "Bitiş Tarihi";
            // 
            // GiderListeleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 607);
            this.Controls.Add(this.gbxFiltreleme);
            this.Controls.Add(this.gbxGiderEkleme);
            this.Controls.Add(this.dgvGiderListeleme);
            this.Name = "GiderListeleme";
            this.Text = "GiderListeleme";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiderListeleme)).EndInit();
            this.gbxGiderEkleme.ResumeLayout(false);
            this.gbxGiderEkleme.PerformLayout();
            this.gbxFiltreleme.ResumeLayout(false);
            this.gbxFiltreleme.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGiderListeleme;
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
        private System.Windows.Forms.GroupBox gbxFiltreleme;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label lblBitişTarihi;
        private System.Windows.Forms.Label lblFBaslangicTarihi;
        private System.Windows.Forms.Label lblFTarihAralik;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lblFIcerik;
    }
}