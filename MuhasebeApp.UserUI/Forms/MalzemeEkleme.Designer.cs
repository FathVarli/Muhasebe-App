
namespace MuhasebeApp.UserUI.Forms
{
    partial class MalzemeIslemleri
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
            this.lblAd = new System.Windows.Forms.Label();
            this.lblBirim = new System.Windows.Forms.Label();
            this.lblBirimFiyat = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtBirim = new System.Windows.Forms.TextBox();
            this.txtBirimFiyati = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnEkle = new System.Windows.Forms.Button();
            this.bntBack = new System.Windows.Forms.Button();
            this.dgwMalzeme = new System.Windows.Forms.DataGridView();
            this.btnSil = new System.Windows.Forms.Button();
            this.gbxEkleGuncelle = new System.Windows.Forms.GroupBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.gbxFiltreleme = new System.Windows.Forms.GroupBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.txtAdArama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAdaGoreArama = new System.Windows.Forms.Label();
            this.validationError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgwMalzeme)).BeginInit();
            this.gbxEkleGuncelle.SuspendLayout();
            this.gbxFiltreleme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.validationError)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(19, 62);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(20, 13);
            this.lblAd.TabIndex = 0;
            this.lblAd.Text = "Ad";
            // 
            // lblBirim
            // 
            this.lblBirim.AutoSize = true;
            this.lblBirim.Location = new System.Drawing.Point(19, 96);
            this.lblBirim.Name = "lblBirim";
            this.lblBirim.Size = new System.Drawing.Size(29, 13);
            this.lblBirim.TabIndex = 1;
            this.lblBirim.Text = "Birim";
            // 
            // lblBirimFiyat
            // 
            this.lblBirimFiyat.AutoSize = true;
            this.lblBirimFiyat.Location = new System.Drawing.Point(19, 127);
            this.lblBirimFiyat.Name = "lblBirimFiyat";
            this.lblBirimFiyat.Size = new System.Drawing.Size(56, 13);
            this.lblBirimFiyat.TabIndex = 2;
            this.lblBirimFiyat.Text = "Birim Fiyatı";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(96, 54);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 20);
            this.txtAd.TabIndex = 3;
            this.txtAd.Validating += new System.ComponentModel.CancelEventHandler(this.txtAd_Validating);
            // 
            // txtBirim
            // 
            this.txtBirim.Location = new System.Drawing.Point(96, 89);
            this.txtBirim.Name = "txtBirim";
            this.txtBirim.Size = new System.Drawing.Size(100, 20);
            this.txtBirim.TabIndex = 4;
            this.txtBirim.Validating += new System.ComponentModel.CancelEventHandler(this.txtBirim_Validating);
            // 
            // txtBirimFiyati
            // 
            this.txtBirimFiyati.Location = new System.Drawing.Point(96, 127);
            this.txtBirimFiyati.Name = "txtBirimFiyati";
            this.txtBirimFiyati.Size = new System.Drawing.Size(100, 20);
            this.txtBirimFiyati.TabIndex = 5;
            this.txtBirimFiyati.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBirimFiyati_KeyPress);
            this.txtBirimFiyati.Validating += new System.ComponentModel.CancelEventHandler(this.txtBirimFiyati_Validating);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(27, 185);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(57, 23);
            this.btnEkle.TabIndex = 8;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // bntBack
            // 
            this.bntBack.Location = new System.Drawing.Point(12, 483);
            this.bntBack.Name = "bntBack";
            this.bntBack.Size = new System.Drawing.Size(75, 23);
            this.bntBack.TabIndex = 9;
            this.bntBack.Text = "Geri Dön";
            this.bntBack.UseVisualStyleBackColor = true;
            // 
            // dgwMalzeme
            // 
            this.dgwMalzeme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMalzeme.Location = new System.Drawing.Point(41, 30);
            this.dgwMalzeme.Name = "dgwMalzeme";
            this.dgwMalzeme.ReadOnly = true;
            this.dgwMalzeme.Size = new System.Drawing.Size(657, 150);
            this.dgwMalzeme.TabIndex = 10;
            this.dgwMalzeme.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwMalzeme_CellClick);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(153, 185);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(57, 23);
            this.btnSil.TabIndex = 11;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // gbxEkleGuncelle
            // 
            this.gbxEkleGuncelle.Controls.Add(this.btnGuncelle);
            this.gbxEkleGuncelle.Controls.Add(this.txtAd);
            this.gbxEkleGuncelle.Controls.Add(this.btnSil);
            this.gbxEkleGuncelle.Controls.Add(this.lblAd);
            this.gbxEkleGuncelle.Controls.Add(this.lblBirim);
            this.gbxEkleGuncelle.Controls.Add(this.lblBirimFiyat);
            this.gbxEkleGuncelle.Controls.Add(this.btnEkle);
            this.gbxEkleGuncelle.Controls.Add(this.txtBirim);
            this.gbxEkleGuncelle.Controls.Add(this.txtBirimFiyati);
            this.gbxEkleGuncelle.Location = new System.Drawing.Point(471, 218);
            this.gbxEkleGuncelle.Name = "gbxEkleGuncelle";
            this.gbxEkleGuncelle.Size = new System.Drawing.Size(227, 246);
            this.gbxEkleGuncelle.TabIndex = 12;
            this.gbxEkleGuncelle.TabStop = false;
            this.gbxEkleGuncelle.Text = "Ekleme-Güncelleme";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(90, 185);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(57, 23);
            this.btnGuncelle.TabIndex = 12;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // gbxFiltreleme
            // 
            this.gbxFiltreleme.Controls.Add(this.btnAra);
            this.gbxFiltreleme.Controls.Add(this.txtAdArama);
            this.gbxFiltreleme.Controls.Add(this.label1);
            this.gbxFiltreleme.Controls.Add(this.lblAdaGoreArama);
            this.gbxFiltreleme.Location = new System.Drawing.Point(41, 218);
            this.gbxFiltreleme.Name = "gbxFiltreleme";
            this.gbxFiltreleme.Size = new System.Drawing.Size(200, 246);
            this.gbxFiltreleme.TabIndex = 13;
            this.gbxFiltreleme.TabStop = false;
            this.gbxFiltreleme.Text = "Arama";
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(133, 217);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(61, 23);
            this.btnAra.TabIndex = 14;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // txtAdArama
            // 
            this.txtAdArama.Location = new System.Drawing.Point(35, 89);
            this.txtAdArama.Name = "txtAdArama";
            this.txtAdArama.Size = new System.Drawing.Size(100, 20);
            this.txtAdArama.TabIndex = 14;
            this.txtAdArama.TextChanged += new System.EventHandler(this.txtAdArama_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Ad:";
            // 
            // lblAdaGoreArama
            // 
            this.lblAdaGoreArama.AutoSize = true;
            this.lblAdaGoreArama.Location = new System.Drawing.Point(9, 65);
            this.lblAdaGoreArama.Name = "lblAdaGoreArama";
            this.lblAdaGoreArama.Size = new System.Drawing.Size(88, 13);
            this.lblAdaGoreArama.TabIndex = 14;
            this.lblAdaGoreArama.Text = "Ada Göre Arama:";
            // 
            // validationError
            // 
            this.validationError.ContainerControl = this;
            // 
            // MalzemeIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 562);
            this.Controls.Add(this.gbxFiltreleme);
            this.Controls.Add(this.gbxEkleGuncelle);
            this.Controls.Add(this.dgwMalzeme);
            this.Controls.Add(this.bntBack);
            this.Name = "MalzemeIslemleri";
            this.Text = "Malzeme";
            this.Load += new System.EventHandler(this.MalzemeIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwMalzeme)).EndInit();
            this.gbxEkleGuncelle.ResumeLayout(false);
            this.gbxEkleGuncelle.PerformLayout();
            this.gbxFiltreleme.ResumeLayout(false);
            this.gbxFiltreleme.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.validationError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblBirim;
        private System.Windows.Forms.Label lblBirimFiyat;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtBirim;
        private System.Windows.Forms.TextBox txtBirimFiyati;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button bntBack;
        private System.Windows.Forms.DataGridView dgwMalzeme;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.GroupBox gbxEkleGuncelle;
        private System.Windows.Forms.GroupBox gbxFiltreleme;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.TextBox txtAdArama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAdaGoreArama;
        private System.Windows.Forms.ErrorProvider validationError;
        private System.Windows.Forms.Button btnGuncelle;
    }
}