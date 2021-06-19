
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
            this.components = new System.ComponentModel.Container();
            this.dgwGiderListeleme = new System.Windows.Forms.DataGridView();
            this.gbxGiderEkleme = new System.Windows.Forms.GroupBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.txtToplamTutar = new System.Windows.Forms.TextBox();
            this.txtIcerik = new System.Windows.Forms.TextBox();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.lblIcerik = new System.Windows.Forms.Label();
            this.gbxFiltreleme = new System.Windows.Forms.GroupBox();
            this.btnFilterClear = new System.Windows.Forms.Button();
            this.btnAra = new System.Windows.Forms.Button();
            this.dtpFStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblFIcerik = new System.Windows.Forms.Label();
            this.dtpFEndDate = new System.Windows.Forms.DateTimePicker();
            this.txtFIcerik = new System.Windows.Forms.TextBox();
            this.lblFTarihAralik = new System.Windows.Forms.Label();
            this.lblFBaslangicTarihi = new System.Windows.Forms.Label();
            this.lblBitişTarihi = new System.Windows.Forms.Label();
            this.validationError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgwGiderListeleme)).BeginInit();
            this.gbxGiderEkleme.SuspendLayout();
            this.gbxFiltreleme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.validationError)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwGiderListeleme
            // 
            this.dgwGiderListeleme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwGiderListeleme.Location = new System.Drawing.Point(33, 21);
            this.dgwGiderListeleme.Name = "dgwGiderListeleme";
            this.dgwGiderListeleme.ReadOnly = true;
            this.dgwGiderListeleme.Size = new System.Drawing.Size(758, 253);
            this.dgwGiderListeleme.TabIndex = 0;
            this.dgwGiderListeleme.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwGiderListeleme_CellClick);
            // 
            // gbxGiderEkleme
            // 
            this.gbxGiderEkleme.Controls.Add(this.btnSil);
            this.gbxGiderEkleme.Controls.Add(this.btnGüncelle);
            this.gbxGiderEkleme.Controls.Add(this.txtAciklama);
            this.gbxGiderEkleme.Controls.Add(this.dtpTarih);
            this.gbxGiderEkleme.Controls.Add(this.txtToplamTutar);
            this.gbxGiderEkleme.Controls.Add(this.txtIcerik);
            this.gbxGiderEkleme.Controls.Add(this.lblAciklama);
            this.gbxGiderEkleme.Controls.Add(this.lblTarih);
            this.gbxGiderEkleme.Controls.Add(this.lblToplamTutar);
            this.gbxGiderEkleme.Controls.Add(this.lblIcerik);
            this.gbxGiderEkleme.Location = new System.Drawing.Point(412, 280);
            this.gbxGiderEkleme.Name = "gbxGiderEkleme";
            this.gbxGiderEkleme.Size = new System.Drawing.Size(379, 296);
            this.gbxGiderEkleme.TabIndex = 1;
            this.gbxGiderEkleme.TabStop = false;
            this.gbxGiderEkleme.Text = "Gider Ekleme";
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(132, 244);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 9;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Location = new System.Drawing.Point(257, 244);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGüncelle.TabIndex = 8;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = true;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(132, 148);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(200, 74);
            this.txtAciklama.TabIndex = 7;
            // 
            // dtpTarih
            // 
            this.dtpTarih.Location = new System.Drawing.Point(132, 109);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(200, 20);
            this.dtpTarih.TabIndex = 6;
            // 
            // txtToplamTutar
            // 
            this.txtToplamTutar.Location = new System.Drawing.Point(132, 71);
            this.txtToplamTutar.Name = "txtToplamTutar";
            this.txtToplamTutar.Size = new System.Drawing.Size(100, 20);
            this.txtToplamTutar.TabIndex = 5;
            this.txtToplamTutar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtToplamTutar_KeyPress);
            this.txtToplamTutar.Validating += new System.ComponentModel.CancelEventHandler(this.txtToplamTutar_Validating);
            // 
            // txtIcerik
            // 
            this.txtIcerik.Location = new System.Drawing.Point(132, 34);
            this.txtIcerik.Name = "txtIcerik";
            this.txtIcerik.Size = new System.Drawing.Size(200, 20);
            this.txtIcerik.TabIndex = 4;
            this.txtIcerik.Validating += new System.ComponentModel.CancelEventHandler(this.txtIcerik_Validating);
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
            this.gbxFiltreleme.Controls.Add(this.btnFilterClear);
            this.gbxFiltreleme.Controls.Add(this.btnAra);
            this.gbxFiltreleme.Controls.Add(this.dtpFStartDate);
            this.gbxFiltreleme.Controls.Add(this.lblFIcerik);
            this.gbxFiltreleme.Controls.Add(this.dtpFEndDate);
            this.gbxFiltreleme.Controls.Add(this.txtFIcerik);
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
            // btnFilterClear
            // 
            this.btnFilterClear.Location = new System.Drawing.Point(46, 244);
            this.btnFilterClear.Name = "btnFilterClear";
            this.btnFilterClear.Size = new System.Drawing.Size(102, 23);
            this.btnFilterClear.TabIndex = 53;
            this.btnFilterClear.Text = "Filtreleleri Temizle";
            this.btnFilterClear.UseVisualStyleBackColor = true;
            this.btnFilterClear.Click += new System.EventHandler(this.btnFilterClear_Click);
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(231, 244);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(75, 23);
            this.btnAra.TabIndex = 51;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // dtpFStartDate
            // 
            this.dtpFStartDate.Location = new System.Drawing.Point(114, 118);
            this.dtpFStartDate.Name = "dtpFStartDate";
            this.dtpFStartDate.Size = new System.Drawing.Size(181, 20);
            this.dtpFStartDate.TabIndex = 47;
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
            // dtpFEndDate
            // 
            this.dtpFEndDate.Location = new System.Drawing.Point(114, 151);
            this.dtpFEndDate.Name = "dtpFEndDate";
            this.dtpFEndDate.Size = new System.Drawing.Size(181, 20);
            this.dtpFEndDate.TabIndex = 48;
            // 
            // txtFIcerik
            // 
            this.txtFIcerik.Location = new System.Drawing.Point(84, 64);
            this.txtFIcerik.Name = "txtFIcerik";
            this.txtFIcerik.Size = new System.Drawing.Size(130, 20);
            this.txtFIcerik.TabIndex = 1;
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
            // validationError
            // 
            this.validationError.ContainerControl = this;
            // 
            // GiderListeleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 607);
            this.Controls.Add(this.gbxFiltreleme);
            this.Controls.Add(this.gbxGiderEkleme);
            this.Controls.Add(this.dgwGiderListeleme);
            this.Name = "GiderListeleme";
            this.Text = "GiderListeleme";
            this.Load += new System.EventHandler(this.GiderListeleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwGiderListeleme)).EndInit();
            this.gbxGiderEkleme.ResumeLayout(false);
            this.gbxGiderEkleme.PerformLayout();
            this.gbxFiltreleme.ResumeLayout(false);
            this.gbxFiltreleme.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.validationError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwGiderListeleme;
        private System.Windows.Forms.GroupBox gbxGiderEkleme;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.TextBox txtToplamTutar;
        private System.Windows.Forms.TextBox txtIcerik;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label lblToplamTutar;
        private System.Windows.Forms.Label lblIcerik;
        private System.Windows.Forms.GroupBox gbxFiltreleme;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.DateTimePicker dtpFEndDate;
        private System.Windows.Forms.DateTimePicker dtpFStartDate;
        private System.Windows.Forms.Label lblBitişTarihi;
        private System.Windows.Forms.Label lblFBaslangicTarihi;
        private System.Windows.Forms.Label lblFTarihAralik;
        private System.Windows.Forms.TextBox txtFIcerik;
        private System.Windows.Forms.Label lblFIcerik;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.ErrorProvider validationError;
        private System.Windows.Forms.Button btnFilterClear;
    }
}