
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
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMalzeme)).BeginInit();
            this.gbxEkleGuncelle.SuspendLayout();
            this.gbxFiltreleme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.validationError)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.Location = new System.Drawing.Point(19, 62);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(22, 15);
            this.lblAd.TabIndex = 0;
            this.lblAd.Text = "Ad";
            // 
            // lblBirim
            // 
            this.lblBirim.AutoSize = true;
            this.lblBirim.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBirim.Location = new System.Drawing.Point(19, 96);
            this.lblBirim.Name = "lblBirim";
            this.lblBirim.Size = new System.Drawing.Size(40, 15);
            this.lblBirim.TabIndex = 1;
            this.lblBirim.Text = "Birim";
            // 
            // lblBirimFiyat
            // 
            this.lblBirimFiyat.AutoSize = true;
            this.lblBirimFiyat.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBirimFiyat.Location = new System.Drawing.Point(19, 127);
            this.lblBirimFiyat.Name = "lblBirimFiyat";
            this.lblBirimFiyat.Size = new System.Drawing.Size(74, 15);
            this.lblBirimFiyat.TabIndex = 2;
            this.lblBirimFiyat.Text = "Birim Fiyatı";
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.Location = new System.Drawing.Point(96, 54);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 21);
            this.txtAd.TabIndex = 3;
            // 
            // txtBirim
            // 
            this.txtBirim.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBirim.Location = new System.Drawing.Point(96, 89);
            this.txtBirim.Name = "txtBirim";
            this.txtBirim.Size = new System.Drawing.Size(100, 21);
            this.txtBirim.TabIndex = 4;
            // 
            // txtBirimFiyati
            // 
            this.txtBirimFiyati.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBirimFiyati.Location = new System.Drawing.Point(96, 127);
            this.txtBirimFiyati.Name = "txtBirimFiyati";
            this.txtBirimFiyati.Size = new System.Drawing.Size(100, 21);
            this.txtBirimFiyati.TabIndex = 5;
            this.txtBirimFiyati.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBirimFiyati_KeyPress);
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(30, 185);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(80, 30);
            this.btnEkle.TabIndex = 8;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // bntBack
            // 
            this.bntBack.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bntBack.Location = new System.Drawing.Point(12, 566);
            this.bntBack.Name = "bntBack";
            this.bntBack.Size = new System.Drawing.Size(80, 25);
            this.bntBack.TabIndex = 9;
            this.bntBack.Text = "Geri Dön";
            this.bntBack.UseVisualStyleBackColor = true;
            this.bntBack.Click += new System.EventHandler(this.bntBack_Click);
            // 
            // dgwMalzeme
            // 
            this.dgwMalzeme.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgwMalzeme.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgwMalzeme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMalzeme.Location = new System.Drawing.Point(154, 37);
            this.dgwMalzeme.Name = "dgwMalzeme";
            this.dgwMalzeme.ReadOnly = true;
            this.dgwMalzeme.RowHeadersVisible = false;
            this.dgwMalzeme.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwMalzeme.Size = new System.Drawing.Size(188, 150);
            this.dgwMalzeme.TabIndex = 10;
            this.dgwMalzeme.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwMalzeme_CellClick);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(250, 185);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(80, 30);
            this.btnSil.TabIndex = 11;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // gbxEkleGuncelle
            // 
            this.gbxEkleGuncelle.Controls.Add(this.label2);
            this.gbxEkleGuncelle.Controls.Add(this.btnGuncelle);
            this.gbxEkleGuncelle.Controls.Add(this.txtAd);
            this.gbxEkleGuncelle.Controls.Add(this.btnSil);
            this.gbxEkleGuncelle.Controls.Add(this.lblAd);
            this.gbxEkleGuncelle.Controls.Add(this.lblBirim);
            this.gbxEkleGuncelle.Controls.Add(this.lblBirimFiyat);
            this.gbxEkleGuncelle.Controls.Add(this.btnEkle);
            this.gbxEkleGuncelle.Controls.Add(this.txtBirim);
            this.gbxEkleGuncelle.Controls.Add(this.txtBirimFiyati);
            this.gbxEkleGuncelle.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxEkleGuncelle.Location = new System.Drawing.Point(372, 239);
            this.gbxEkleGuncelle.Name = "gbxEkleGuncelle";
            this.gbxEkleGuncelle.Size = new System.Drawing.Size(360, 250);
            this.gbxEkleGuncelle.TabIndex = 12;
            this.gbxEkleGuncelle.TabStop = false;
            this.gbxEkleGuncelle.Text = "Ekleme-Güncelleme";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(140, 185);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(80, 30);
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
            this.gbxFiltreleme.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxFiltreleme.Location = new System.Drawing.Point(41, 239);
            this.gbxFiltreleme.Name = "gbxFiltreleme";
            this.gbxFiltreleme.Size = new System.Drawing.Size(320, 250);
            this.gbxFiltreleme.TabIndex = 13;
            this.gbxFiltreleme.TabStop = false;
            this.gbxFiltreleme.Text = "Arama";
            // 
            // btnAra
            // 
            this.btnAra.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.Location = new System.Drawing.Point(132, 195);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(80, 30);
            this.btnAra.TabIndex = 14;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // txtAdArama
            // 
            this.txtAdArama.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdArama.Location = new System.Drawing.Point(48, 96);
            this.txtAdArama.Name = "txtAdArama";
            this.txtAdArama.Size = new System.Drawing.Size(100, 21);
            this.txtAdArama.TabIndex = 14;
            this.txtAdArama.TextChanged += new System.EventHandler(this.txtAdArama_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(22, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Ad:";
            // 
            // lblAdaGoreArama
            // 
            this.lblAdaGoreArama.AutoSize = true;
            this.lblAdaGoreArama.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdaGoreArama.Location = new System.Drawing.Point(22, 72);
            this.lblAdaGoreArama.Name = "lblAdaGoreArama";
            this.lblAdaGoreArama.Size = new System.Drawing.Size(101, 15);
            this.lblAdaGoreArama.TabIndex = 14;
            this.lblAdaGoreArama.Text = "Ada Göre Arama:";
            // 
            // validationError
            // 
            this.validationError.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(202, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "TL";
            // 
            // MalzemeIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(744, 601);
            this.Controls.Add(this.gbxFiltreleme);
            this.Controls.Add(this.gbxEkleGuncelle);
            this.Controls.Add(this.dgwMalzeme);
            this.Controls.Add(this.bntBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MalzemeIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Label label2;
    }
}